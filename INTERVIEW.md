# INTERVIEW

## Parte I - Experiência

1. Descreva a sua experiência mais relevante na participação da implantação/manutenção de um CI/CD.

Auxiliei na implementação de um ambiente de CI/CD, utilizando o [GitHub Flow](https://guides.github.com/introduction/flow/), através das ferramentas GitLab, Docker e Linux.
Integrei neste ambiente servidores Windows, para a inclusão de aplicações em plataforma Microsoft e Desktop no processo de CI/CD.
Criei, integralmente, um ambiente de CI/CD para utilizando GitHub, Circle CI e Amazon ESB, para a publicação de aplicações Web com as tecnologias: Aurelia, DotNet e Java/Scala.

2. Quais projetos você já fez num ambiente Cloud (AWS, GCP...)? Cite aqui coisas como funções lambda, cloudformation, criação de grupos de scaling, EC2, loadbalancer, entre outros.

 * Lambda: Utilizei lambda e Python para criar serviços de processamento de imagens, além de notificações;
 * Cloudformation: Apenas estudei esta tecnologia, no intuito de migrar do ESB para cloudformation;
 * Loadbalancer: Configurei instancias de LoadBalancer com NGINX;
 * ESB: Configurei um ambiente de CI/CD multiplataforma.


3. Qual sua experiência com containers? Já trabalhou com k8s? Conte sobre sua experiência com essas tecnologias.

Uso extensivamente containers no dia à dia, tanto para desenvolvimento quanto para deploy de aplicações.
Não possuo experiência com kubernetes, atualmente estou estudando Docker Swarm para a orquestração de containers.

4. Já participou de migrações e procedimentos críticos? Descreva como foi.

Participei da migração de ambientes da infraestrutura do CIASC para a Prefeitura de Joinville, foram migrados dois sistemas: SGC Sistema de Gestão Cadastral, que era constituído por Linux, Ruby on Rails e Oracle e a NFEM com ambinete Windows DotNet e SqlServer.
Na época da migração, não haviamos implementado a tecnologia de containers, por isso foram criados servidores internos com as mesmas caracteristicas dos servidores externos, foi efetuada uma pré migração da aplicação e do banco de dados, sendo efetuados testes pelos usuários internos, para validar funcionalidades e possíveis problemas.
Após a validação dos usuários, os problemas foram corrigidos e a migração efetuada. Apesar de todos os cuidados, ocorreram vários problemas com a migração, sendo que os principais foram problemas de performance devido as configurações do Oracle e problemas com referências aos servidores através do endereço IP.

5. Já utilizou ferramentas de monitoramento como NewRelic, Sentry, Cloudwatch, Prometheus e VictorOps? Como foi a sua experiência? Pode citar outras, queremos saber quais métricas você coletava e quais ações aconteciam.

Atualmente utilizo as seguintes tecnologias para monitoramento:

 * Slack como canal de notificações para exceções e problemas;
 * Grafana para geração de gráficos;
 * Prometheus para armazenamento dos dados;
 * Resmon para os indicadores.

6. Qual sua experiência com SQL? Qual sua experiência otimizando o desempenho de banco/consultas? Conte um dos seus momentos mais "memoráveis" nesse aspecto.

7. Qual sua experiência com programação? Já fez alguma otimização de algoritmo que deu uma melhora significativa em um projeto? Qual a coisa mais complexa que já construiu?

Tenho grande experiência com desenvolvimento, trabalhei com várias plataformas, entre elas PHP, Ruby on Rails, Python, Java/Scala e Asp.Net.
Dentre os sistemas complexos que criei, estão um sistema para automatizar a geração e manutenção de usuários no Active Directory e a adaptação de um sistema de OAuth para autenticação e autorização de aplicações de terceiros.
Dentre as melhorias de sistemas, destaco a adaptação de um sistema de execução em lotes que reduziu significativamente o tempo de processamento para diferentes clientes (item 9).

8. Tem alguma experiência com CI/CD para aplicativos mobile?

Não possuo experiência com CI/CD para mobile, mais já estive envolvido na criação de aplicativos.

9. Já trabalhou com filas assíncronas (AMQP) como Sidekiq e Celery? Qual a sua experiência?

Não utilizei estas tecnologias, para processamento assíncrono, utilizo uma aplicação de linha de comando que é executada continuamente, esta aplicação varre a base de dados e verifica quais registros estão pendentes de processamento. Para cada cliente da aplicação, é gerada uma nova thread, que processa e marca os arquivos como processados. Caso ocorra algum problema neste processo, o registro  é marcado para revisão e é enviada uma notificação via e-mail para o suporte.
