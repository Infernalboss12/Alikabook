﻿const passwordField = document.getElementById('password');
const togglePassword = document.getElementById('togglePassword');
const confirmPasswordField = document.getElementById('confirmPassword');
const toggleConfirmPassword = document.getElementById('toggleConfirmPassword');

togglePassword.addEventListener('click', () => {
    const type = passwordField.type === 'password' ? 'text' : 'password';
    passwordField.type = type;
});


toggleConfirmPassword.addEventListener('click', () => {
    const type = confirmPasswordField.type === 'password' ? 'text' : 'password';
    confirmPasswordField.type = type;
});
