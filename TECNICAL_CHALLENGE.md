# TECNICAL CHALLENGE

## Parte II - Desafio técnico

Desenvolver uma aplicação CLI executável, **utilizando docker**, que seja capaz de ler um
**arquivo csv** ou um **arquivo json** contendo endereços de clientes que **devem ser agrupados
por estado**. O arquivo para leitura pode estar local (num diretório onde o app será utilizado) ou
remoto (através de uma requisição http). Sua aplicação deverá ser capaz de tratar **os 4
cenários**:

 * Receber um endereço **remoto** para um **arquivo csv**
 * Receber um endereço **local** para um **arquivo csv**
 * Receber um endereço **remoto** para um **arquivo json**
 * Receber um endereço **local** para um **arquivo json**

## Exemplo de Chamada para todos os 4 casos

```
app.py http://endereco.url.com/arquivo.csv
app.py /home/user/arquivo.csv
app.py http://endereco.url.com/arquivo.json
app.py /home/user/arquivo.json
```

**Importante**: sua aplicação não pode receber nenhum outro parâmetro que não o endereço.
Você deverá descobrir o tipo do arquivo internamente na aplicação. **Não assuma que a
nomenclatura do arquivo seja o suficiente para diferenciar os tipos.**

## Exemplos de Arquivos para Teste

https://gist.githubusercontent.com/israelbgf/fbdb325cd35bc5b956b2e350d354648a/raw/b26d28f
4c01a1ec7298020e88a200d292293ae4b/conteudojson

https://gist.githubusercontent.com/israelbgf/782a92243d0ba1ff47f9aaf46358f870/raw/86c7a2bf0
4242bd4262b203ca725ce1da69f035d/conteudocsv

A aplicação deve processar o conteúdo do arquivo e exibir no terminal uma lista de estados em
ordem alfabética informando ao lado a quantidade de clientes daquele estado.

Durante a entrevista será solicitada uma pequena alteração no funcionamento do programa,
portanto é importante garantir a flexibilidade da solução. Você pode utilizar qualquer linguagem
de programação ou biblioteca que tiver interesse.

## O Entregável

Você deverá publicar sua imagem docker em um repositório a sua escolha e nos passar o
endereço/acesso para testarmos localmente. Além disso, queremos acesso a um
repositório git com o seu código e seus commits. No projeto crie um README com instruções
de uso do seu projeto.
