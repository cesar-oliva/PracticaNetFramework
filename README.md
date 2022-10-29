# NET Framework

Este proyecto es la plantilla base sobre la cual se realizaran las practicas de Net Framework

## particularidades
- La plantilla tiene configurada la version 4.8 de NET Framework (ultima version).
- Bootstrap se actualizo a la version 4.6 para tener acceso a la documentación.
- La libreria de JQuery se movio al Header de la web para no tener problemas al utilizar la libreria.

## Consideraciones
- No tiene configurado Entity Framework. Se deben agregar la libreria "EntityFramework" y habilitar migraciones con el comando "Enable-Migrations" para poder utilizar Code First.

## Comandos para Migraciones
- Enable-Migrations
- Add-migrations [Nombre]
- Update-Database
