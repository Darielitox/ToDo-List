# 📝 Todo List — Gestión de Tareas

Aplicación de consola desarrollada en **C# (.NET)** para gestionar una lista de tareas de forma sencilla, con persistencia de datos en archivo de texto.

---

## 📋 Descripción

Sistema que permite agregar y eliminar tareas desde la consola. Las tareas se guardan automáticamente en un archivo `Tareas.txt`, por lo que persisten aunque cierres el programa.

---

## ✨ Características

- ➕ **Agregar tareas** con validación de entrada vacía
- ❌ **Eliminar tareas** por número de posición
- 💾 **Persistencia automática** — las tareas se guardan en `Tareas.txt`
- ⚠️ **Validaciones** — avisa cuando no hay tareas o se ingresa una opción inválida
- 🖥️ Banner ASCII art en la interfaz

---

## 🗂️ Estructura del Proyecto

```
ToDo_List/
├── Program.cs      # Lógica principal, menú y gestión de tareas
└── Tareas.txt      # Archivo de tareas (generado automáticamente)
```

---

## ▶️ Cómo Ejecutar

### Requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) 9.0 o superior

### Pasos

```bash
# Clonar el repositorio
git clone https://github.com/Darielitox/todo-list.git
cd todo-list

# Compilar y ejecutar
dotnet run
```

---

## 🎮 Uso

| Opción | Descripción |
|--------|-------------|
| 1 | Agregar una nueva tarea |
| 2 | Eliminar una tarea por número |
| 3 | Salir del programa |

Las tareas se muestran numeradas en la parte superior de la pantalla en todo momento.

---

## 👤 Autor

**Dariel De Jesus** — 2025-2155 - Estudiante de Seguridad Informatica ITLA

---

## 📄 Licencia

Este proyecto es de uso libre para fines educativos.
