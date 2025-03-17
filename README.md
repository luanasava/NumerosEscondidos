# Números Escondidos

## Resumo
Este projeto foi desenvolvido para resolver um quebra-cabeça lógico chamado **Números Escondidos**. O objetivo é encontrar todos os números inteiros positivos dentro de um intervalo dado `[A, B]` que satisfaçam as seguintes condições:

1. **Divisibilidade por `C`**: O número deve ser divisível por `C`.
2. **Soma dos dígitos**: A soma dos dígitos do número deve ser maior ou igual a `D`.
3. **Dígitos proibidos**: O número não pode conter nenhum dígito presente na lista `E`.

---

## Como Funciona

O projeto é implementado em **C#** e consiste em uma função principal chamada `EncontrarNumerosEscondidos`, que recebe os seguintes parâmetros:

- **A**: Início do intervalo.
- **B**: Fim do intervalo.
- **C**: Divisor.
- **D**: Soma mínima dos dígitos.
- **E**: Lista de dígitos proibidos.

A função retorna uma lista de números que satisfazem todas as condições acima.

### Funcionalidades

1. **Validações**:
   - Verifica se `A` e `B` são positivos.
   - Garante que `A <= B`.
   - Valida se `C` e `D` são valores válidos.
   - Verifica se os elementos da lista `E` estão entre 0 e 9.

2. **Eficiência**:
   - Pula números que não são divisíveis por `C` para evitar cálculos desnecessários.
   - Calcula a soma dos dígitos e verifica dígitos proibidos apenas para números divisíveis por `C`.

3. **Testes**:
   - Inclui vários casos de teste para validar o funcionamento do código em diferentes cenários.

---
## Estrutura do Código


**Função Principal**


* EncontrarNumerosEscondidos: Encontra os números que atendem as condições.



**Funções Auxiliares**


* DivisivelporC: Verifica se um número é divisível por C.

* SomaDigitos: Calcula a soma dos dígitos de um número.

* ContemDigitoInvalido: Verifica se um número contém algum dígito da lista E.

## Testes:

Vários casos de teste são executados no método Main para validar o código.
