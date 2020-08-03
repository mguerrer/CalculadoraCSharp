Feature: REQ-002-OperacionesIU
	La calculadora puede administrar un stack de datos en que va
	manejando el progreso de las operaciones.
Background:
	Given Abrí la calculadora
# El @ indica una etiqueta para el método que implementa el test case o Scenario.
@Resta
Scenario: Puede borrar contenido
	Given Ingresé el número 70 en la calculadora
	When Ingresé la operación C
	Then El resultado debiera ser 0 en la pantalla
	And Cerré la calculadora