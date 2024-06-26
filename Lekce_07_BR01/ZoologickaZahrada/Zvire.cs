﻿namespace Lekce_07_BR01.ZoologickaZahrada;

public abstract class Zvire
{
    public int Vek { get; private set; }

    public string Druh { get; private set; }

    public Zvire(int vek, string druh)
    {
        Vek = vek;
        Druh = druh;
    }

    public abstract void VydavejZvuk();
}
