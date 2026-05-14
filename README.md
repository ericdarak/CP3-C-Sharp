# Registro de Operacoes Financeiras

Console Application em **C# / .NET 8.0** que simula o registro de operacoes de compra e venda de ativos financeiros.

## Integrantes

Eric Darakjian - RM557082
Luciano Meriato - RM554546

## Evidencias de Teste

### Teste 1 - Registrar uma COMPRA
```
1 - Registrar operacao
Tipo (1=Compra, 2=Venda): 1
Codigo do ativo (ex: PETR4): PETR4
Quantidade: 10
Preco: 2,00

COMPRA registrada com sucesso! ID: 001
```

### Teste 2 - Listar operacoes
```
--- Historico de Operacoes ---
COMPRA: [001] 11/05/2025 19:08 - PETR4 x10 @ R$ 2,00 = R$ 20,00
COMPRA: [002] 11/05/2025 19:08 - VALE3 x20 @ R$ 3,00 = R$ 60,00
VENDA: [003] 11/05/2025 19:08 - ITUB4 x10 @ R$ 2,00 = R$ 20,00
```

### Teste 3 - Mostrar valor total
```
Valor total de compras:  R$ 80,00
Valor total de vendas:   R$ 20,00
```

### Teste 4 - Tratamento de excecoes
```
Tipo (1=Compra, 2=Venda): 5
Erro: Tipo invalido. Use 1 para Compra ou 2 para Venda.

Quantidade: abc
Erro: valor digitado nao e um numero valido.

Quantidade: -5
Erro: Quantidade deve ser maior que zero.
```
