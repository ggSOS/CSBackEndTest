using System;

namespace CSBackEndTest;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public float Preco { get; set; }
    public int Quantidade { get; set; }
}
