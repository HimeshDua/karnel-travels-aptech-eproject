/*
 * Karnel Travel Guide - Client-side JavaScript
 * Minimal JavaScript for form interactions
 */

// This file is intentionally minimal as per requirements
// No JavaScript frameworks (React, Angular, Vue) are used
console.log('Karnel Travel Guide loaded');

document.addEventListener("DOMContentLoaded", () => {
    const toggle = document.querySelector(".nav-toggle");
    const menu = document.querySelector(".nav-menu");

    toggle?.addEventListener("click", () => {
        menu.classList.toggle("open");
    });
});
