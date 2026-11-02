//6-os, 7-es, 1-es

//6-os

int jelszo_erosseg(string jelszo)
{
    if (jelszo.Contains("jelszo"))
    {
        return 0;
    }
    if (jelszo.Contains("123"))
    {
        return 0;
    }
    if (jelszo.Length == 0)
    {
        return 0;
    }

    int erosseg = 1;

    if (jelszo.Count() >= 5)
    {
        erosseg++;
    }
    if (jelszo.Count() >= 8)
    {
        erosseg += 2;
    }
    foreach (char s in jelszo)
    {
        if (s == '_')
        {
            erosseg += 2;
        }
        if (s == '-')
        {
            erosseg += 2;
        }
        if (s == '.')
        {
            erosseg += 2;
        }
    }
    return erosseg;
}
Console.WriteLine(jelszo_erosseg("hazi_macska_4_life"));
Console.WriteLine(jelszo_erosseg("ez1feltorhetetlenjelszo"));


//7-es

string maganhangzot_torol(string szoveg)
{
    string maganhangzok = "aeuio";
    string newstr = "";
    
    foreach (char c in szoveg)
    {
        if (maganhangzok.Contains(c)){
            continue;
        }
        else
        {
            newstr += c;
        }
    }
    return newstr;
}

Console.WriteLine(maganhangzot_torol("Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol."));

//8-as

string kodol(string uzenet, int n, char ch)
{
    string kod = "";
    for (int i = 0; i < n; i++)
    {
        kod += ch;
    }


    string newstr = "";
    foreach (char c in uzenet)
    {
        newstr += c;
        newstr += kod;
    }
    return newstr;
}
Console.WriteLine(kodol("Pizza delben?",3,'x'));