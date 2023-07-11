Algoritmo PrimerParcialDanielMarhon
	
		Definir radio, altura, area, volumen Como Real;
		Definir cantidadCilindros Como Entero;
		cantidadCilindros <- -1;
		
		Repetir
			Escribir "Ingrese el radio del cilindro (0 para salir):";
			Leer radio;
			
			Escribir "Ingrese la altura del cilindro (0 para salir):";
			Leer altura;
			
			cantidadCilindros <- cantidadCilindros + 1;
			
			area <- 2 * 3.1416 * radio * (radio + altura);
			volumen <- 3.1416 * radio * radio * altura;
            
			Escribir "El área del cilindro es:", area;
			Escribir "El volumen del cilindro es:", volumen;
			Escribir "";
			
		Hasta Que radio = 0 Y altura = 0
		
		Escribir "Se ingresaron ", cantidadCilindros, " cilindros.";
		
FinAlgoritmo