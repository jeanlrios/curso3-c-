using NonoDesafio.Devices;

ExibirInfo laptop = new Laptop();
laptop.NomeDevice = "Laptop";
laptop.Processador = "i5 12ªgen";
laptop.Ram = "8Gb";
laptop.Armazenamento = "SSD 500Gb";
laptop.ExibirInformacoes();

ExibirInfo smartphone = new Smartphone();
smartphone.NomeDevice = "Smartphone";
smartphone.Processador = "Snapdragon";
smartphone.Ram = "4Gb";
smartphone.Armazenamento = "128Gb";
smartphone.ExibirInformacoes();

ExibirInfo tablet = new Tablet();
tablet.NomeDevice = "Tablet";
tablet.Processador = "Exynos";
tablet.Ram = "8Gb";
tablet.Armazenamento = "64Gb";
tablet.ExibirInformacoes();
