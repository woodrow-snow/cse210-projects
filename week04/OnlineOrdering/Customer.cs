class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool DoesLiveInUS()
    {
        return _address.LiveInUs();
    }

    public string GetMailingAddress()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }

    public string GetName()
    {
        return _name;
    }
}