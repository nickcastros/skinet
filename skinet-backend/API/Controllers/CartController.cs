using System;
using Microsoft.AspNetCore.Mvc;
using skinet.Core.Entities;
using skinet.Core.Interfaces;

namespace skinet.API.Controllers;

public class CartController(ICartService cartService) : BaseAPIController
{
    [HttpGet]
    public async Task<ActionResult<ShoppingCart>> GetCartById(string id)
    {
        var cart = await cartService.GetCartAsync(id);
        return Ok(cart ?? new ShoppingCart { Id = id });
    }

    [HttpPost]
    public async Task<ActionResult<ShoppingCart>> UpdateCart(ShoppingCart cart)
    {
        var updated = await cartService.SetCartAsync(cart);
        if (updated == null) return BadRequest("Problem updating the cart");
        return Ok(updated);
}   

    [HttpDelete]
    public async Task<ActionResult> DeleteCart(string id)
    {
        var result = await cartService.DeleteCartAsync(id);
        if (!result) return BadRequest("Problem deleting the cart");
        return Ok(true);
    }



}
