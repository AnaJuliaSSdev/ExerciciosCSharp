### Maior prefixo comum

 Escreva uma função para encontrar a string de prefixo comum mais longa entre um array/lista de strings. Se não houver prefixo comum, retorne uma string vazia "".

**Exemplo 1:**

```
Entrada:  strs ? ["flor","flow","flight"]
Saída: "fl"
```

**Exemplo 2:**
```
Entrada: strs ? ["dog","racecar","car"]
Saída: ""
Explicação: Não há nenhum prefixo comum entre as cadeias de entrada.
```

**Dica: Utilize loops e condicionais**


### Parênteses válidos

Dado uma string que contém apenas os caracteres '(', ')' , '{', '}', '[' e ']', determine se a entrada da string é válida. 

**Uma entrada de string é válida se:**

1. Abre parenteses deve ser fechado com fecha parenteses. 
2. Abre chaves deve ser fechado com chaves.
3. Abre colchetes deve ser fechado com colchetes. 

Ou seja, cada caractere de fechamento deve ter um caractere de abertura do mesmo tipo.

Exemplo 1:

	Entrada: s ? "()" (
	
	Saída: true

Exemplo 2:

	Entrada: s ? "()[]"

	Saída: true

Exemplo 3:

	Input: s ? "(]" (

	Saída: false

Exemplo 4:

	Entrada: s ? "([[])"

	Saída: true


**Dica: Utilize Stack**

### Mais um

Você recebeu um número inteiro grande, representado como dígitos de um array de inteiros, onde cada dígito[i] é o i-ésimo dígito do número inteiro. Os dígitos são ordenados do mais significativo para o menos significativo, da esquerda para a direita. O número inteiro grande não contém nenhum 0 à esquerda. 
Aumente o número inteiro grande em um e retorne o array de dígitos resultantes. 

I**Exemplo 1:**

```
Entrada: digits = [1,2,3]
Saída: [1,2,4]
Explicação: O Array representa o inteiro 123.
Aumentando em um temos 123 + 1 = 124. Assim, o resultado deve ser [1,2,4]

```

**Exemplo 2:**

```
Entrada: digits = [4,3,2,1]
Saída: [4,3,2,2]
Explicação: O Array representa o inteiro 4321.
Aumentando em um temos 4321 + 1 = 4322.
Assim, o resultado deve ser [4,3,2,2].
```

**Exemplo 3:**

```
Entrada: digits = [9]
Saída: [1,0]
Explicação: O Array representa o inteiro 9.
Aumentando em um temos 9 + 1 = 10.
Assim, o resultado deve ser [1,0].

```


**Dica**: 
Os digitos só vão de 0 a 9, e não contém nenum 0 à esquerda. 

