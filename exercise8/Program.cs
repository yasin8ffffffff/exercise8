using exercise8;

ApiHelper.InitializeClient();
var coininfo = await Read_api.code();

Console.WriteLine($"Your information about Bitcoin: price {coininfo.last}\n Name {coininfo.symbol}\n Price changing{coininfo.changeprice}\n" +
    $"average{coininfo.averageprice}\n Rate{coininfo.changeRate}\n");

