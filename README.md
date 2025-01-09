# PRUEBA TÉCNICA JONATHAN ORTEGA



## PREGUNTA 1



Justificación de Decisiones Arquitectónicas TeCnologías:
C#, Su integración con .NET proporciona herramientas robustas para manejar lógica de negocio compleja y APIs RESTful de alto rendimiento y es ideal para sistemas empresariales que requieren manejo eficiente de datos y características como validación y autorización.
Angular (Frontend) soporta aplicaciones de una sola página (SPA) para una experiencia de usuario fluida es reactivo e ideal para dashboards interactivos y reportes dinámicos.
PostgreSQL (Base de Datos Relacional) es compatible con transacciones ACID y extensiones avanzadas como PostGIS para datos geográficos.
Docker (Contenerización), facilita la implementación y escalabilidad mediante la creación de contenedores portables. Permite despliegues consistentes en diferentes entornos.

Escalabilidad y Disponibilidad:
Crecimiento de Datos
Particionado de Datos
Sharding
Redundancia y Alta Disponibilidad(CDN)
Replica de Base de Datos
Caché
Uso de Redis para almacenar consultas frecuentes y sincronizar inventarios en tiempo real.

Seguridad:
Protección de Datos Sensibles:
Encriptación en Reposo con AES.
Encriptación en Tránsito con TLS.

Autenticación y Autorización:
JWT

Auditoría:
Registro de cambios en inventario para monitorear accesos y actualizaciones.

Sincronización en Tiempo Real:
RabbitMQ
Redis

##PREGUNTA 2
(.NET 8)
Navegar a la carpeta PREGUNTA 2

Para realizar las pruebas ejecutar el siguiente comando: dotnet test