﻿document.querySelectorAll('.cart__item-remove').forEach(button => {
    button.addEventListener('click', function () {
        var cartId = this.getAttribute('data-cart-id');
        document.getElementById('cartItemId').value = cartId;
        document.getElementById('removeForm').submit();
    });
});

function updateCartSummary() {
    let subtotal = 0;

    document.querySelectorAll('.bookTotalPrice').forEach(el => {
        subtotal += parseFloat(el.textContent.replace('₱', '').trim());
    });

    // Update subtotal and total fields in the UI
    document.getElementById('subTotal').textContent = `₱${subtotal.toFixed(2)}`;
    const shipping = 85; // Static or dynamically calculated
    const tax = 25.23; // Static or dynamically calculated
    document.getElementById('estimatedTotal').textContent = `₱${(subtotal + shipping + tax).toFixed(2)}`;
}

const cartQuantities = document.querySelectorAll('.cartQuantity');
const btnDecreases = document.querySelectorAll('.btnDecrease');
const btnIncreases = document.querySelectorAll('.btnIncrease');
const bookPrices = document.querySelectorAll('.bookPrice');
const bookTotalPrices = document.querySelectorAll('.bookTotalPrice');
const subTotal = document.getElementById('subTotal');
const estimatedTotal = document.getElementById('estimatedTotal');

const formBookQuantities = document.querySelectorAll('.order-book-quantity');
const formTotalPrice = document.getElementById('orderTotalPrice');

function updateSubtotal() {
    let subtotal = 0;
    let total = 0;
    const shipping = 85;
    const tax = 25.23;

    bookTotalPrices.forEach(totalPriceElement => {
        const totalPrice = parseFloat(totalPriceElement.textContent.replace('₱', '').replace(',', ''));
        subtotal += totalPrice;
    });

    subTotal.textContent = `₱${subtotal.toFixed(2)}`;
    estimatedTotal.textContent = `₱${(subtotal + shipping + tax).toFixed(2)}`;
    formTotalPrice.value = (subtotal + shipping + tax).toFixed(2);
}

cartQuantities.forEach((cartQuantity, index) => {
    let cart = parseInt(cartQuantity.textContent);
    let bookPrice = parseFloat(bookPrices[index].textContent.replace('₱', '').replace(',', ''));
    let bookTotalPrice = bookTotalPrices[index];
    let formBookQuantity = formBookQuantities[index];

    btnDecreases[index].addEventListener('click', () => {
        if (cart > 1) {
            cart -= 1;
            cartQuantity.textContent = cart;
            formBookQuantity.value = cart;

            bookTotalPrice.textContent = `₱${(cart * bookPrice).toFixed(2)}`;

            updateSubtotal(); 
        }
    });

    btnIncreases[index].addEventListener('click', () => {
        cart += 1;
        cartQuantity.textContent = cart;
        formBookQuantity.value = cart;

        bookTotalPrice.textContent = `₱${(cart * bookPrice).toFixed(2)}`;

        updateSubtotal(); 
    });
});
