# meus-pedidos-code-challenge

Interview and project to Meus Pedidos code challenge.

App to group users, by state, from remote or local file, supports JSON and CSV format. More details in the [Tecnical Challenge](https://github.com/fontanaricardo/meus-pedidos-code-challenge/blob/master/TECNICAL_CHALLENGE.md).

To group the users from remote use the command:

```
docker run fontanaricardo/group https://gist.githubusercontent.com/israelbgf/fbdb325cd35bc5b956b2e350d354648a/raw/b26d28f4c01a1ec7298020e88a200d292293ae4b/conteudojson
```

To group the user from local file use de command:

```
docker run -v <folder>:<folder> fontanaricardo/group <folder>/<file>
```

To start a new development environment, use the command:

```
docker run -it --rm -v $PWD:/app microsoft/dotnet:2.1-sdk bash
```
