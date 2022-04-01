using Project;

Bank Sberbank = new Bank("Сбербанк");
Bank Tinkoff = new Bank("Тинькофф");

Client Sava = new Client("Сарбаев", "Савелий", "Дмитриевич");

Account SberAcc = new Account("85920566820485715379", Sberbank, Sava,Currency.Dollar);
Account TinAcc = new Account("56783459275610675925", Tinkoff, Sava, Currency.Yuan);

Card SberCard = new Card("4817 2009 7115 1411", Sberbank, "618", Sava, new DateTime(2024 / 8  / 11), PaymentType.MIR, SberAcc);
Card TinCard = new Card("5323 5002 8916 6157", Tinkoff, "923", Sava, new DateTime(2025 / 05 / 03), PaymentType.MasterCard, TinAcc);

SberAcc.Balance = 25000m;
TinAcc.Balance = 36560m;

var check = SberCard.Withdraw(4000m);

Console.WriteLine(SberCard.Withdraw(4000m));

//Console.WriteLine(check);
Console.WriteLine(TinCard.Refill(2034));


//Console.WriteLine(check);