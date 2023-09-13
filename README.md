# AppFutebol
App feito em Net Maui usando Api Rest para consumir dados de jogos e jogadores do brasileirão 2023
<p align="center">
<img loading="lazy" src="https://raw.githubusercontent.com/Marcos-Jose-DV/AppFutebol/main/AppFuteboll.png"/>
</p>
<h1>Resumo do projeto</h1>
<p>Framework que usei para criar esse app foi Net Maui, O .NET MAUI (Multi-platform App UI) é um framework de código aberto da Microsoft que permite o desenvolvimento de aplicativos multiplataforma para dispositivos móveis, desktop e web, usando uma única base de código em C#. Ele é uma evolução do Xamarin.Forms e foi projetado para simplificar ainda mais o desenvolvimento de aplicativos multiplataforma. </p>

<p>Ultilindo REST API (Representational State Transfer Application Programming Interface) é um conjunto de regras e convenções para a criação e interação com serviços web. Ela é baseada nos princípios do REST, um estilo arquitetônico de desenvolvimento de sistemas distribuídos. </p>

hammer: Funcionalidades do projeto

- **Listagem de Jogos do Brasileirão 2023**: Exibe os jogos de futebol agendados para a data atual. Os usuários podem rolar para ver os jogos e também têm a opção de avançar ou retroceder para ver os jogos de datas anteriores ou futuras.

- **Tabela do Brasileirão 2023**: Apresenta a tabela de classificação do Campeonato Brasileiro de 2023. Os usuários podem visualizar as posições das equipes, os pontos conquistados e outros detalhes importantes.

- **Artilheiros do Campeonato**: Mostra os principais artilheiros do Campeonato Brasileiro de 2023. Os usuários podem ver quem está liderando a artilharia e quantos gols cada jogador marcou.

- **Controle de Data**: Permite aos usuários avançar ou retroceder na programação dos jogos, facilitando a visualização de jogos passados e futuros.

:earth_americas: Endpoints da API

- **Obter Principais Artilheiros (Top Scorers)**: Este endpoint permite ao aplicativo recuperar informações sobre os principais artilheiros do campeonato. Ele fornece uma lista dos jogadores que marcaram mais gols na competição, juntamente com seus nomes, equipes e a quantidade de gols que marcaram.

  - Endpoint: `https://apiv3.apifootball.com/?action=get_topscorers`

- **Obter Classificação (Standings)**: Este endpoint permite ao aplicativo obter a classificação atual das equipes no Campeonato que quiser. Ele fornece informações sobre as equipes, como posição na tabela, pontos ganhos, partidas jogadas e muito mais.

  - Endpoint: `https://apiv3.apifootball.com/?action=get_standings`
