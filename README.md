# Fiotec Prova Analista II 

Desenvolver utilizando padrão de arquitetura de software uma WebAPI Rest que
consulta a WebAPI da Campanha Nacional de Vacinação Covid-19 com a finalidade de
saber quantas vacinas da Pfizer foram aplicadas no RJ em determinado dia.

   O padrão de arquitetura deve ser escolhido pelo participante;
   O banco de dados utilizado deve ser SQL e providenciado pelo próprio participante;
   A WebAPI Rest deve ser aberta, podendo ser utilizada por qualquer pessoa, apenas informando nome e CPF;
   Os dados do solicitante (Nome e CPF) devem ser salvos no banco e não podem se repetir. Se um usuário já solicitou algumas vez, na próxima deve apenas referenciá-lo.
   Podem ser realizadas diversas requisições de relatórios;
   Todo relatório deve ser salvo em banco com as seguintes informações:
    o Data da solicitação
    o Descrição do relatório (que deve ser: “Relatório Vacinas Pfizer aplicadas no RJ_Data da aplicação”)
    o Data da aplicação
    o Quantidade total de vacinados (Informação deve ser obtida através da WebAPI da Campanha de Vacinação)
    o Solicitante
   Para buscar o total de vacinas aplicadas, a fabricante da vacina sempre será
“Pfizer” e a UF sempre será “RJ”. Apenas o dia da aplicação da vacina deve ser
informada pelo usuário.
   Deve existir relacionamento entre as tabelas de solicitante e relatório;
   Deve ser possível listar todos os relatórios salvos no banco. Documentação da API da Campanha de Vacinação: https://opendatasus.saude.gov.br/dataset/covid-19-vacinacao 
  
  
Entrega do Projeto:
   Deve ser colocado em um repositório aberto do github, com o arquivo dump do banco sql usado no projeto.
