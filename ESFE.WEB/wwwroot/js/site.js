// =============================================================================
// LÓGICA DE INTERACCIÓN Y NAVEGACIÓN CLIENTE - MAISON ÉLITE
// =============================================================================

/**
 * Cambia dinámicamente entre la vista de Login y Registro de Cliente.
 */
function toggleAuthView(event, targetView) {
    if (event) event.preventDefault();

    const loginBox = document.getElementById('view-login');
    const registerBox = document.getElementById('view-register');

    if (!loginBox || !registerBox) return;

    if (targetView === 'register') {
        loginBox.classList.add('d-none');
        registerBox.classList.remove('d-none');
    } else {
        registerBox.classList.add('d-none');
        loginBox.classList.remove('d-none');
    }
}

/**
 * Maneja el registro de nuevos usuarios (Simulación Frontend / Cliente).
 */
function handleRegisterSubmit(event) {
    event.preventDefault();

    const nameInput = document.getElementById('regName');
    const emailInput = document.getElementById('regEmail');

    if (!nameInput || !emailInput) return;

    const name = nameInput.value.trim();
    const email = emailInput.value.trim().toLowerCase();

    if (email.includes("@tienda.com")) {
        alert(`¡Registro Exitoso! Bienvenido ${name}. Asignado al equipo interno de la tienda.`);
    } else {
        alert(`¡Registro Exitoso! Bienvenido ${name}. Redirigiendo al catálogo...`);
    }
}

/**
 * Autenticación simulada con Google.
 */
function handleGoogleAuth() {
    alert("Iniciando autenticación con Google...");
}