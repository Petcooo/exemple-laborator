namespace Lab02_Petcoviciu_Alexandru.Domain
{
    public record ValidatedShoppingCart(ProductCode productCode, Quantity quantity, Address address, Price price);
}
