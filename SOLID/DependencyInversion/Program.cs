// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

ReportOperations reportOperations = new ReportOperations(new MailSender());

reportOperations.Send();

ReportOperations reportOperations1 = new ReportOperations(new WhatsAppSender());
reportOperations1.Send();

ReportOperations reportOperations2 = new ReportOperations(new DiscordSender());
reportOperations2.Send();

//reportOperations.Sender = new MailSender();
