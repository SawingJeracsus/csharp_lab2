class Converter
{
    private double usd;
    private double eur;
    private double rub;
    public Converter(double usd, double eur, double rub)
    {
        this.usd = usd;
        this.eur = eur;
        this.rub = rub;
    }

    public Currency convertUan(double uan)
    {
        return new Currency(uan, this.usd, this.eur, this.rub);
    }
}

class Currency
{
    private readonly double value;
    private double usd;
    private double eur;
    private double rub;
    public Currency(double value, double usd, double eur, double rub)
    {
        this.value = value;

        this.usd = usd;
        this.eur = eur;
        this.rub = rub;
    }

    public double toUsd()
    {
        return this.value * this.usd;
    }
    public double toEur()
    {
        return this.value * this.eur;
    }
    public double toRub()
    {
        return this.value * this.rub;
    }
}