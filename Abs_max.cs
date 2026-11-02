int abs_max(int elso, int masodik)
{
    elso = Math.Abs(elso);
    masodik = Math.Abs(masodik);
    if (elso < masodik)
    {
        return masodik;
    }
    else
    {
        return elso;
    }
}
Console.WriteLine(abs_max(12, -15));

