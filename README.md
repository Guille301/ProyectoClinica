<img width="256" height="256" alt="logo_clinica" src="https://github.com/user-attachments/assets/be95f766-e8f7-406c-b7c5-0d4990a7f930" />

# Sistema de gestión para la Clínica Carupano

Aplicación web para la gestión de pacientes en un entorno clínico off-line. Permite registrar pacientes, administrar historias clínicas y registrar evoluciones médicas. Desarrollada en ASP.NET Core 8 con arquitectura en capas y base de datos SQLite.

---

## Cómo correr el programa

### Opción 1 — Usando el ejecutable (recomendado)

1. Abrí una terminal en la carpeta `Ejecutable` del proyecto.
2. Ejecutá el siguiente comando:

```bash
dotnet run
```

3. El programa iniciará el servidor automáticamente y abrirá el navegador en la página de login (`http://localhost:5062/Login/Login`).
4. Cuando quieras cerrar la aplicación, volvé a la terminal y **presioná cualquier tecla**. Esto detendrá el servidor.

### Opción 2 — Corriendo el proyecto MVC directamente

Si preferís, podés iniciar el servidor MVC directamente desde su carpeta:

1. Abrí una terminal en la carpeta `ClinicaMvc`.
2. Ejecutá:

```bash
dotnet run
```

3. Abrí el navegador y accedé a `http://localhost:5062/Login/Login`.

---

## Base de datos

El sistema usa una base de datos **SQLite** que ya viene incluida en el proyecto (`ClinicaMvc/Database/Database.sqlite`). No es necesario instalar ni configurar ningún motor de base de datos externo.



