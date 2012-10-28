


Mailee.me - Integração com .NET
=================
Biblioteca para integração do Mailee.me com .NET
por Caique Dourado - http://twitter.com/caiquedourado


Configuração
=================
Adicione no Web.Config sua chave de API e o subdomínio utilizado no Mailee.me.
Exemplo: Se a URL da API é http://api.cb3n376h66a1r.seusite.mailee.me/, informe o valor ‘cb3n376h66a1r’ na chave de configuração “MaileeKey” e o valor “seusite” na chave de configuração “MaileeSubdomain”, ficando dessa forma:
```c#
<configuration>
  <appSettings>
    <!-- Mailee - SecretKey -->
    <add key="MaileeKey" value="cb3n376h66a1r"/>
    <!-- Mailee - Subdomain -->
    <add key="MaileeSubdomain" value="seusite"/>
  </appSettings>
</configuration>
```

Contatos
=================

Criar um contato
-----------------
```c#

//Create Contact
Mailee.Contact contact = new Mailee.Contact();
contact.Email = "email@site.com";
contact.Name = "Nome";
contact.InternalId = 33;
contact.Company = "Empresa";
contact.Position = "Cargo";
contact.Sex = "M";
contact.Birthday = new DateTime(1986,1,30);
contact.Age = 25;
contact.Phone = "(71) 9999-8888";
contact.Mobile = "(71) 9999-8888";
contact.Address = "Rua Teste, S/N";
contact.Notes = "Anotações do Contato";

//Add Optional Fields
contact.DynamicValues.Add(new KeyValuePair<string,string>("Campo 1","Valor 1"));
contact.DynamicValues.Add(new KeyValuePair<string,string>("Campo 2","Valor 2"));

//Save
contact.save();
```

Atualizar um contato
-----------------
```c#
//Find Contact
Mailee.Contact contact = Mailee.Contact.findById(1);

//Update Fields
contact.Email = "email@site.com";
contact.Name = "Nome";
contact.InternalId = 33;
contact.Company = "Empresa";
contact.Position = "Cargo";
contact.Sex = "M";
contact.Birthday = new DateTime(1986, 1, 30);
contact.Age = 25;
contact.Phone = "(71) 9999-8888";
contact.Mobile = "(71) 9999-8888";
contact.Address = "Rua Teste, S/N";
contact.Notes = "Anotações do Contato";

//Add Optional Fields
contact.DynamicValues.Add(new KeyValuePair<string, string>("Campo 1", "Valor 1"));
contact.DynamicValues.Add(new KeyValuePair<string, string>("Campo 2", "Valor 2"));

//Save
contact.save();
```

Buscar todos os contatos
------------------
```c#
//Find All Contacts
List<Mailee.Contact> contacts = Mailee.Contact.findAll();
```

Buscar um contato pelo ID
-------------------
```c#
//Find Contact by Id
Mailee.Contact contact = Mailee.Contact.findById(1);
```

Buscar um contato pelo Internal ID
-----------------
```c#
//Find Contact by Internal Id
Mailee.Contact contact = Mailee.Contact.findByInternalId(1);
```

Buscar um contato pelo Email
-----------------
```c#
//Find Contact by Email
Mailee.Contact contact = Mailee.Contact.findByEmail("email@site.com"); 
```

Inscrever o contato em uma Lista
-----------------
```c#

//Find Contact by Id
Mailee.Contact contact = Mailee.Contact.findById(1);

//Subscribe contact to list (List Id = 99)
contact.Subscribe(99);

//Subscribe contact to list (List Name = ”clients”)
contact.Subscribe("clients");
```

Remover o contato de uma Lista
-----------------
```c#

//Find Contact by Id
Mailee.Contact contact = Mailee.Contact.findById(1);

//Unsubscribe contact to list (List Id = 99)
contact.Unsubscribe(99);

//Unsubscribe contact to list (List Name = 'clients')
contact.Unsubscribe("clients");

```

Listas
=================

Criar uma Lista
-----------------
```c#

//Create List
Mailee.List list = new Mailee.List();
list.Name = "Nome da Lista";
list.Description = "Descrição da List;
list.Company = "Empresa";
list.Address = "Rua Teste S/N"; 
list.Phone = "(71) 9999-8888"; 
list.Site = "www.site.com"; 
list.Facebook = "facebook.com/seulogin"; 
list.Twitter = "twitter.com/seulogin"; 
list.Active = true;

//Save
list.save();
```

Atualizar uma Lista
-----------------
```c#

//Find List
Mailee.List list = Mailee.List.findById(1);

//Update Fields
list.Name = "Nome da Lista"; 
list.Description = "Descrição da Lista";
list.Company = "Empresa";
list.Address = "Rua Teste S/N"; 
list.Phone = "(71) 9999-8888"; 
list.Site = "www.site.com"; 
list.Facebook = "facebook.com/seulogin"; 
list.Twitter = "twitter.com/seulogin"; 
list.Active = true;

//Save
list.save();
```

Buscar todas as listas
-----------------
```c#

//Find All Lists
List<Mailee.List> lists = Mailee.List.findAll(); 3.4 Buscar uma lista pelo ID

//Find List by Id
Mailee.List list = Mailee.List.findById(1);
```

Templates
==============
Criar um Template
--------------
```c#

//Create Template
Mailee.Template template = new Mailee.Template(); 
template.Title = "Título do Template";
template.Html = "<html><body>Hello World!</body></html>";

//Save
template.save();
```
Atualizar um Template
--------------
```c#
//Find Template
Mailee.Template template = Mailee.Template.findById(1);

//Update Fields
template.Title = "Título do Template";
template.Html = "<html><body>Hello World!</body></html>";

//Save
template.save();
```

Buscar todos os templates
--------------
```c#
//Find All Templates
List<Mailee.Template> templates = Mailee.Template.findAll(); 
```

Buscar um template pelo ID
--------------
```c#
//Find Template by Id
Mailee.Template template = Mailee.Template.findById(1);
```

Mensagens
================

Criar uma Mensagem (usando HTML)
-------------
```c#
//Create Message
Mailee.Message message = new Mailee.Message();
message.Title = "Título da Mensagem";
message.Subject = "Assunto da Mensagem"; 
message.FromName = "Nome do Destinatário";
message.FromEmail = "Email do Destinatário";
message.ReplyEmail = "Email para Resposta"; 
message.Html = "<html><body>Hello World!</body></html>"; 
message.Analytics = true;
message.Emails = "email_teste_1@site.com, email_teste_2@site.com, email_teste_3@site.com"; 

//Save
message.save();
```

Criar uma Mensagem (usando um Template)
-------------
```c#
//Create Message
Mailee.Message message = new Mailee.Message(); 
message.Title = "Título da Mensagem";
message.Subject = "Assunto da Mensagem"; 
message.FromName = "Nome do Destinatário";
message.FromEmail = "Email do Destinatário";
message.ReplyEmail = "Email para Resposta"; 
message.TemplateId = 1;
message.Analytics = true;
message.Emails = "email_teste_1@site.com, email_teste_2@site.com, email_teste_3@site.com";

//Save
message.save();
```

Criar uma Mensagem (enviando para uma lista/segmento)
-------------
```c#
//Create Message
Mailee.Message message = new Mailee.Message(); 
message.Title = "Título da Mensagem";
message.Subject = "Assunto da Mensagem"; 
message.FromName = "Nome do Destinatário";
message.FromEmail = "Email do Destinatário";
message.ReplyEmail = "Email para Resposta"; 
message.Html = "<html><body>Hello World!</body></html>"; 
message.TemplateId = 1;
message.Analytics = true; 
message.ListId = 1; 
message.SegmentId = 1;

//Save
message.save();
```

Atualizar uma Mensagem
-------------
```c#
//Find Message
Mailee.Message message = Mailee.Message.findById(1);

//Update Fields
message.Title = "Título da Mensagem";
message.Subject = "Assunto da Mensagem"; 
message.FromName = "Nome do Destinatário";
message.FromEmail = "Email do Destinatário";
message.ReplyEmail = "Email para Resposta"; 
message.Html = "<html><body>Hello World!</body></html>"; 
message.TemplateId = 1;
message.Analytics = true;
message.Emails = "email_teste_1@site.com, email_teste_2@site.com, email_teste_3@site.com";

//Save
message.save();
```
Buscar todas as mensagens
-------------
```c#

//Find All Messages
List<Mailee.Message> messages = Mailee.Message.findAll(); 
```

Buscar uma mensagem pelo ID
-------------
```c#
//Find Message by Id
Mailee.Message message = Mailee.Message.findById(1);
```

Relatórios
===============
Relatório de Acesso
---------
```c#
//Get Report
Mailee.Report findReport = Mailee.Report.findByMessage(messageId);
```


Tratamento de Erros
=============
```c#
try
{
  //CODE
}
catch (Mailee.RestExcepction ex) {
  //Show error messages
  foreach (string error in ex.ErrorMessages) {
    Response.Write("<br />" + error); 
    }
  //Show http status
  Response.Write("StatusCode = " + ex.StatusCode); 
  Response.Write("StatusDesciption = " + ex.StatusDesciption);
}
catch (Exception ex) {
  //Show excepction message
Response.Write(ex.Message); 
}
```
