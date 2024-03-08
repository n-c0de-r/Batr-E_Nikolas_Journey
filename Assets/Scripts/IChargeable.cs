// Interface, defines method to charge or uncharge any object 
public interface IChargeable
{
    void recharge(float amount);
    float decharge(float amount);
    void resetColor();
}
