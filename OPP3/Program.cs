using OPP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKredisiManager = new EsnafKredisiManager();


ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILoggerService> { new DatabaseLoggerService(), new SMSLoggerService() });

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };