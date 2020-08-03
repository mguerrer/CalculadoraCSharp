# Feature define el requerimiento.    Es informativo y no genera código.
Feature: REQ_001_OperacionesBásicas
	La calculadora puede recibir y operar OP (+,-,*,/) varios números.
	Si hay más de un número ingresado al apretar OP da el total 
	al igual que al apretar =.
# El @ indica una etiqueta para el método que implementa el test case o Scenario.
@Suma
Scenario: Suma 2 números
	Given Abrí la calculadora
	And Ingresé el número 70 en la calculadora
	And Ingresé la operación + en la calculadora
	And Ingresé el número 50 en la calculadora
	When Ingresé la operación =
	Then El resultado debiera ser 120 en la pantalla
	And Cerré la calculadora

Scenario: Resta 2 números
	Given Abrí la calculadora
	Given Ingresé el número 70 en la calculadora
	And Ingresé la operación - en la calculadora
	And Ingresé el número 50 en la calculadora
	When Ingresé la operación =
	Then El resultado debiera ser 20 en la pantalla
	And Cerré la calculadora

Scenario: Multiplica 2 números
	Given Abrí la calculadora
	And Ingresé el número 7 en la calculadora
	And Ingresé la operación * en la calculadora
	And Ingresé el número 5 en la calculadora
	When Ingresé la operación =
	Then El resultado debiera ser 35 en la pantalla
	And Cerré la calculadora

Scenario: Divide 2 números
	Given Abrí la calculadora
	And Ingresé el número 70 en la calculadora
	And Ingresé la operación / en la calculadora
	And Ingresé el número 7 en la calculadora
	When Ingresé la operación =
	Then El resultado debiera ser 10 en la pantalla
	And Cerré la calculadora

Scenario: Múltiples operaciones
	Given Abrí la calculadora
	Given Ingresé el número <número> en la calculadora
	When Ingresé la operación <operación>
	Then El resultado debiera ser <resultado> en la pantalla
	Examples: 
	| número | operación | resultado |
	| 1      | +         | 1         |
	| 1      | *         | 2         |
	| 2      | /         | 4         |
	| 2      | =         | 2         |
