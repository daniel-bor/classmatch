# 🎓 ClassMatch

**ClassMatch** es una herramienta open source desarrollada en **.NET 8 MVC** para la **asignación inteligente de estudiantes a cursos, secciones y horarios** bajo un conjunto de reglas de negocio académicas.  
El objetivo es automatizar la creación de secciones, asignación de catedráticos y distribución de estudiantes, considerando tanto **hard constraints** como **soft constraints**.

---

## 🚀 Características principales
- Asignación automática de estudiantes a secciones de cursos.
- Creación de secciones en función del número de inscritos.
- Definición de capacidad mínima y máxima de estudiantes por sección.
- Control de carga académica de los catedráticos.
- Generación de horarios respetando bloques de tiempo y disponibilidad.
- Reglas configurables para validaciones y asignaciones.
- Señalización de problemas (alertas) cuando se rompen reglas críticas.

---

## 📋 Reglas de Negocio

### 🔒 Restricciones Duras (Hard Constraints)
1. **Disponibilidad:**  
   - Un catedrático, salón o grupo de estudiantes no puede estar en dos lugares al mismo tiempo.  
2. **Especialidad del Catedrático:**  
   - Un catedrático solo puede impartir cursos de su especialidad.  
3. **Carga de Catedráticos:**  
   - Cada catedrático debe impartir un **mínimo de 2** y un **máximo de 4** cursos.  
4. **Horario Operativo:**  
   - Las clases se imparten en **bloques de 2 horas**, entre las **7:00 am y 6:00 pm**.  
5. **Rotación de Salones:**  
   - Un catedrático no puede impartir clases en el mismo salón más de una vez al día.  

---

### 📚 Reglas de Asignación de Secciones
1. **Creación Automática:**  
   - Se generan secciones por cada curso inscrito.  
2. **Tamaño Ideal de Sección:**  
   - Entre **25 y 35 estudiantes**.  
3. **División de Grupos Grandes:**  
   - Si un curso tiene más de 35 estudiantes, se crean secciones adicionales hasta cumplir el rango ideal.  
4. **Fusión de Grupos Pequeños (alerta):**  
   - Si se genera una sección con menos de 25 estudiantes, el sistema emite una **alerta** para que un coordinador decida si se fusiona o mantiene.  

---

### 🎯 Objetivos de Optimización (Soft Constraints)
- **Balance de Género:**  
  Intentar que las secciones mantengan una proporción cercana a 50% hombres y 50% mujeres.  
  > Nota: es una preferencia, no una regla estricta, para no bloquear la generación de horarios.  

---

## 🛠️ Tecnologías
- **Backend:** .NET 8 MVC  
- **Base de Datos:** PostgreSQL (via EF Core 8)  
- **ORM:** Entity Framework Core 8  
- **Validaciones:** FluentValidation  
- **Optimización:** MathNet.Numerics (para algoritmos de matching y optimización) 



---

## 🤝 Contribuciones
Las contribuciones son bienvenidas.  
Puedes apoyar de las siguientes maneras:  
- Reportando bugs.  
- Proponiendo mejoras o nuevas reglas de negocio.  
- Enviando PRs con nuevas funcionalidades.  

---
