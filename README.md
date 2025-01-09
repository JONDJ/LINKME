# PRUEBA TÉCNICA LINKME - JONATHAN ORTEGA

## PREGUNTA 1


### Justificación de Decisiones Arquitectónicas TeCnologías
C#, Su integración con .NET proporciona herramientas robustas para manejar lógica de negocio compleja y APIs RESTful de alto rendimiento y es ideal para sistemas empresariales que requieren manejo eficiente de datos y características como validación y autorización.
Angular (Frontend) soporta aplicaciones de una sola página (SPA) para una experiencia de usuario fluida es reactivo e ideal para dashboards interactivos y reportes dinámicos.
PostgreSQL (Base de Datos Relacional) es compatible con transacciones ACID y extensiones avanzadas como PostGIS para datos geográficos.
Docker (Contenerización), facilita la implementación y escalabilidad mediante la creación de contenedores portables. Permite despliegues consistentes en diferentes entornos.

### Escalabilidad y Disponibilidad
Crecimiento de Datos
Particionado de Datos
Sharding
Redundancia y Alta Disponibilidad(CDN)
Replica de Base de Datos
Caché
Uso de Redis para almacenar consultas frecuentes y sincronizar inventarios en tiempo real.

### Seguridad
Protección de Datos Sensibles:
Encriptación en Reposo con AES.
Encriptación en Tránsito con TLS.

### Autenticación y Autorización
JWT

### Auditoría
Registro de cambios en inventario para monitorear accesos y actualizaciones.

### Sincronización en Tiempo Real
RabbitMQ
Redis

## PREGUNTA 2
(.NET 8)
Navegar a la carpeta PREGUNTA 2 cd PREGUNTA2

Para realizar las pruebas ejecutar el siguiente comando: dotnet test

## PREGUNTA 3
(.NET 8)
Navegar a la carpeta PREGUNTA 3 cd PREGUNTA3

Ejecutar uno de los siguientes comandos

docker-compose up --build
docker-compose -f docker-compose.yml up --build
docker-compose -f docker-compose.yml up --build --no-deps
docker-compose -f docker-compose.yml up --build --no-deps --abort-on-container-exit

## PREGUNTA 4
### Preguntas de Experiencia y Estrategia (Evaluación Oral o Escrita)
1.	¿Qué patrones de diseño aplicarías para desacoplar los servicios del ERP y por qué?
Usaría FACTORY para crear servicios SINGLETON creando una capa intermedia entre el ERP y los servicios de negocio para facilitar la integración y escalabilidad.

2.	¿Cómo manejarías la escalabilidad de la base de datos PostgreSQL si el volumen de datos crece significativamente?
Implementaría particionado de datos y sharding para mejorar la eficiencia y reducir el tiempo de respuesta.

3.	¿Cómo asegurarías que las actualizaciones en un sistema crítico como un ERP no afecten la operación en producción?
Implementaría un sistema de monitoreo y alertas para detectar problemas y un plan de contingencia para minimizar el impacto.

4.	Describe un desafío técnico complejo que hayas enfrentado en un proyecto anterior y cómo lo resolviste.
En un proyecto anterior, enfrenté un desafío técnico complejo al implementar una API RESTful con Angular y .NET. La solución requería integrar diferentes tecnologías y servicios, lo que llevó a un diseño de arquitectura complejo. Para resolverlo, utilicé patrones de diseño como FACTORY y SINGLETON para desacoplar los servicios y mejorar la escalabilidad. Además, implementé un sistema de monitoreo y alertas para detectar problemas y un plan de contingencia para minimizar el impacto.