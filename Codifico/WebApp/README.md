# Codifico

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 12.0.2.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).


## Notas DANIEL QUINTERO 27/01/2025


En el directorio WebApi/Database se encuentran unos archivos sql con procedimientos almacenados los cuales se usaron para llenar 
la tabla principal, los dropdowns del modal de creacion, y la data del modal de view order, estos se deben ejecutar antes de la revision 
de la prueba

En la carpeta webapp se encuentra todo lo relacionado a la aplicacion realizada en angular

En la carpeta webapi se encuentra todo  lo relacionado a la aplicacion realizada en .netCore 7.0

## Breve explicación

Despues de ejecutar el script inicial de DB,

Se creo primero el webApi con los controladores necesarios, estos van a las interfaces donde realizarian la logica
de negocio que se requiera y de alli pasa a los interfaces de repositorio donde realiza unicamente las operaciones a la base de datos
adicionalmente, en el archivo Database/AppDbContext se encuentra el mapeo de los objetos de la base de datos

Luego de tener funcional todos los controladores, se realiza la instalacion de SWAGGER para el testeo de los mismos y por ultimo 
se implemementa el proyecto de pruebas unitarias con NUnit

WebApp:
Se creo el componente salespredictonview y asi mismo se enlaza a los dos componentes modales (ordersnewmodal y ordersviewmodal)
quienes son los que se abren al dar click en los botones indicados en el requerimiento

Se realizo instalacion de la libreria angular/materials y su derivados, ya que esta nos ayuda a trabajar de manera mas
eficaz con modales.

En los archivos del directorio services se encuentran todas las peticiones al webApi

Se tenia planeado instalar la libreria toastr para hacer mas amigables los mensajes en la pagina, pero no alcance a realizar 
su implementacion

Por ultimo se realiza subida de archivos a GITHUB

