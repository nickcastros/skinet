import { Component, inject } from '@angular/core';
import { MatButton } from '@angular/material/button';
import {
  MatFormField,
  MatFormFieldModule,
  MatLabel,
} from '@angular/material/form-field';
import { MatInput, MatInputModule } from '@angular/material/input';
import { RouterLink } from '@angular/router';
import { CartService } from '../../../core/services/cart.service';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-order-sumary',
  standalone: true,
  imports: [
    MatButton,
    RouterLink,
    MatFormField,
    MatLabel,
    MatInput,
    CurrencyPipe,
  ],
  templateUrl: './order-sumary.component.html',
  styleUrl: './order-sumary.component.scss',
})
export class OrderSumaryComponent {
  cartService = inject(CartService);
}
