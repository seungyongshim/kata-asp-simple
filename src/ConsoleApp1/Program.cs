


var x = Eff(() => 1);
var y = Eff(() => 2);

Aff<int> z =
    from a in x
    from b in y
    select a + b;

var result = await z.Run();

Console.WriteLine(result); 
