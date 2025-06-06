
````markdown
# 🏫 Tour Virtual Universidad del Norte (VR)

Este proyecto es una experiencia de realidad virtual desarrollada en **Unity** para **Meta Quest 2**, permitiendo al usuario explorar el campus de la **Universidad del Norte** de manera inmersiva. No incluye un menú, ya que el recorrido inicia automáticamente al ejecutar la aplicación.

---

## 🥽 Dispositivo objetivo

- **Modelo:** Meta Quest 2  
- **Resolución por ojo:** 1832 x 1920  
- **Tasa de refresco compatible:** 72Hz / 90Hz  
- **Requisitos mínimos:**  
  - Espacio libre recomendado: 1 GB  
  - Sistema operativo actualizado (v53 o superior)

---

## 🔧 Instalación en Meta Quest 2

### 1. Preparar las gafas

1. Activar el **modo desarrollador** en la app de Meta desde el celular.
2. Conectar las gafas al PC con cable USB-C.
3. Aceptar la solicitud de **depuración USB** en las gafas.

### 2. Compilar desde Unity

1. Abrir el proyecto en Unity.
2. Ir a `File > Build Settings` y seleccionar:
   - Plataforma: **Android**
   - Activar `XR Plugin Management` y seleccionar **Oculus**
3. Click en `Build And Run` o `Build` para generar un archivo `.apk`.

### 3. Instalar manualmente (opcional)

Si ya tienes el archivo `.apk` compilado:

```bash
adb install ruta/del/archivo.apk
````

> Requiere tener ADB instalado y en el PATH del sistema.

---

## 🧱 Estructura de la escena (`SampleScene`)

### 🎥 XR Rig

* `XR Origin (XR Rig)`: Controla la cámara y los controladores en VR.

### 🧩 UI – Paneles informativos

* Contiene elementos tipo `Spatial Panel Manipulator UI`, uno por cada edificio:

  * `UI K`, `UI L`, `UI I`, `UI G`, `UI BAMBU`, `UI CAFE`, `UI FUENTE`
* **Función:** Mostrar información del edificio al que pertenece cuando el usuario se aproxima.

### 🏢 Modelos de edificios y zonas (importados en .fbx)

* `blokkeCT`, `Cafe`, `Bloke G`, `Mapa principal 1.3`, `Coliceo`, `bambu`, `radio`, `plazatext`, `coliseotext`:
  Modelos 3D de zonas y edificios del campus.


### 🌳 Decoración y entorno

* `assets`: Contiene objetos ambientales como:

  * Árboles
  * Arbustos
  * Macetas
  * Mesas y sillas

> Añaden realismo y ambientación al tour.

### 💡 Iluminación y sistema base

* `Lighting`: Configuración global de iluminación.
* `Directional Light`: Simula la luz solar.
* `EventSystem`: Permite interacción con la UI en entorno XR.

## 🚀 Uso

Al iniciar la aplicación en las gafas:

* El usuario entra directamente al tour.
* Puede desplazarse por el entorno utilizando movilidad continua usando los joystick de los mandos (al observr los mandos te dicen que hace cada boton)
* Al acercarse a los edificios, se muestra la información relevante mediante los paneles UI.

---

## 📁 Estructura del proyecto

```
/Assets
  /Scenes           → Escenas del recorrido
  /Scripts          → Scripts de interacción
  /Prefabs          → Elementos reutilizables
  /UI               → Paneles de información por edificio
  /Models (.fbx)    → Representación 3D del campus
  /assets           → Objetos decorativos (árboles, mesas, etc.)
```

---

## 🏗️ Créditos

* **Desarrollado por:** Santiago Carbal, Kairo Tapias y Heiner Herrera.
* **Institución:** Universidad del Norte
* **Tecnologías:** Unity, Meta XR SDK, Blender (modelado)
  
---

  ## 📌 Cosas por hacer (To-Do)

Estas tareas están pendientes de implementación o mejora dentro del proyecto. El desarrollo puede recibir apoyo tanto de estudiantes de la **Facultad de Ingeniería de Sistemas** como de las carreras de **Arquitectura** y **Diseño Gráfico**.

- [ ] Implementar el **movimiento por teletransporte** en todas las zonas accesibles.
- [ ] Añadir las **escenas interiores de los edificios** para un recorrido más completo.
- [ ] Optimizar los **modelos 3D y colisiones**, especialmente en el **Bloque K**.
- [ ] Incorporar **objetos interactivos** que enriquezcan la experiencia del usuario (botones, animaciones, audio, etc.).
- [ ] Mejorar el nivel de **detalle visual** en los modelos 3D existentes.
- [ ] Hacer que la **fuente central funcione** con efectos visuales o partículas.
- [ ] Diseñar y mejorar los **límites del mapa** para que sean más amigables y coherentes con la navegación del usuario.

> Se recomienda la colaboración multidisciplinaria para mejorar tanto el aspecto técnico como visual del recorrido.

---

