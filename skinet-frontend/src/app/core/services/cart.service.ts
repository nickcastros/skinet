import { inject, Injectable, signal } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Cart, CartItem, CartType } from '../../shared/models/cart';
import { Product } from '../../shared/models/product';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  baseUrl = environment.apiUrl;
  private http = inject(HttpClient);
  cart = signal<Cart | null>(null);
  getCart(id: string) {
    return this.http.get<Cart>(this.baseUrl + 'cart?id=' + id).subscribe({
      next: (response) => {
        this.cart.set(response);
      },
    });
  }

  setCart(cart: Cart) {
    return this.http.post<Cart>(this.baseUrl + 'cart', cart).subscribe({
      next: (response) => {
        this.cart.set(response);
      },
    });
  }

  addItemToCard(item: CartItem | Product, quantity = 1) {
    const cart = this.cart() ?? this.createCart();
    if (this.isProduct(item)) {
      item = this.mapProductToCartItem(item);
    }
    cart.items = this.addOrUpdateItem(cart.items, item, quantity);
    this.setCart(cart);
  }
  private addOrUpdateItem(
    items: CartItem[],
    item: CartItem,
    quantity: number
  ): CartItem[] {
    const index = items.findIndex((i) => i.productId === item.productId);
    if (index === -1) {
      item.quantity = quantity;
      items.push({ ...item, quantity });
    } else {
      items[index].quantity += quantity;
    }
    return items;
  }
  private mapProductToCartItem(item: Product): CartItem {
    return {
      productId: item.id,
      productName: item.name,
      price: item.price,
      quantity: 0,
      pictureUrl: item.pictureUrl,
      type: item.type,
      brand: item.brand,
    };
  }
  createCart(): Cart {
    const cart = new Cart();
    localStorage.setItem('cartId', cart.id);
    return cart;
  }

  private isProduct(item: CartItem | Product): item is Product {
    return (item as Product).id !== undefined;
  }
}
