// =============================================================================
// LÓGICA DE INTERACCIÓN, ROLES Y NAVEGACIÓN - MAISON ÉLITE
// =============================================================================

/**
 * Cambia dinámicamente entre la vista de Login y Registro de Cliente.
 */
function toggleAuthView(event, targetView) {
    event.preventDefault(); // Evita recargar la página

    const loginBox = document.getElementById('view-login');
    const registerBox = document.getElementById('view-register');

    if (targetView === 'register') {
        loginBox.classList.add('d-none');
        registerBox.classList.remove('d-none');
    } else {
        registerBox.classList.add('d-none');
        loginBox.classList.remove('d-none');
    }
}

/**
 * Maneja el inicio de sesión y detecta el rol según el correo.
 */
function handleLoginSubmit(event) {
    event.preventDefault();
    const email = document.getElementById('loginEmail').value.toLowerCase();

    // Lógica de detección de roles por dominio / palabra clave en correo:
    if (email.includes("@tienda.com") && email.includes("admin") || email.startsWith("admin@")) {
        alert("Rol detectado: ADMINISTRADOR");
        window.location.href = "/Admin/Index"; // Redirige a pantalla de Administrador
    }
    else if (email.includes("@tienda.com") || email.includes("vendedor")) {
        alert("Rol detectado: VENDEDOR");
        window.location.href = "/Vendedor/Index"; // Redirige a pantalla de Vendedor
    }
    else {
        alert("Rol detectado: CLIENTE");
        window.location.href = "/Cliente/Catalogo"; // Redirige al Catálogo de ropa
    }
}

/**
 * Maneja el registro de nuevos usuarios (Solo para clientes o asignación especial por correo).
 */
function handleRegisterSubmit(event) {
    event.preventDefault();

    const name = document.getElementById('regName').value;
    const email = document.getElementById('regEmail').value.toLowerCase();

    // Asignación especial de Rol en Registro según el correo ingresado:
    if (email.includes("@tienda.com")) {
        if (email.includes("admin")) {
            alert(`¡Registro Exitoso! Bienvenido ${name}. Se te asignó el rol de ADMINISTRADOR.`);
            window.location.href = "/Admin/Index";
        } else {
            alert(`¡Registro Exitoso! Bienvenido ${name}. Se te asignó el rol de VENDEDOR.`);
            window.location.href = "/Vendedor/Index";
        }
    } else {
        // Correo común (@gmail.com, @hotmail.com, etc.) -> Asignación de CLIENTE
        alert(`¡Registro de Cliente Exitoso! Bienvenido ${name}. Redirigiendo al catálogo...`);
        window.location.href = "/Cliente/Catalogo"; // Redirige al Catálogo que harán tus compañeros
    }
}

/**
 * Inicio de Sesión / Registro con Google.
 */
function handleGoogleAuth() {
    alert("Iniciando autenticación con Google (Rol por defecto: Cliente)...");
    window.location.href = "/Cliente/Catalogo";
}