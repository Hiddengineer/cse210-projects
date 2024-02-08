using System.Runtime.CompilerServices;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public void fraction(){
        _numerator = 1;
        _denominator = 1;
    }
    public void fraction(int wholeNumber){
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public void fraction(int numerator, int denominator){
        _numerator = numerator;
        _denominator = denominator;
    }

    public int getNumerator(){
        return _numerator;
    }
    public void setNumerator(int numerator){
        _numerator = numerator;
    }
    
    public int getDenominator(){
        return _denominator;
    }
    public void setDenominator(int denominator){
        _denominator = denominator;
    }

    public String getFractionString(){
        String fractionString;
        fractionString = $"{_numerator}/{_denominator}";
        return fractionString;
    }
    public double getDecimalValue(){
        Double decimalValue;
        decimalValue = (Double)_numerator/_denominator;
        return decimalValue;
    }

}