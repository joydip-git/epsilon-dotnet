namespace InterfaceDemo
{
    //No data members common amongst the classes
    //Only some methods are common
    //And those common methods are all needed to be abstract in the base type
    //In that case choose PURE Abstract type (i.e. interface)
    //Pure abstract type (interface) is the one with ONLY abstract methods or abstract properties
    //No data are part of that abstract type (interface)
    //You will not be able to create instance of that abstract type (interface)
    //abstract methods or properties will be by default public in that abstract type (NO ACCESS SPECIFIERS FOR THEM in INTERFACE)
    // abstract methods or properties will be by default abstract in interface
    //Hence, no need to declare interface methods or properties with either public access specifier or abstract keyword
    //if any class implements this abstract type (interface), then that class must implement ALL the abstract methods and properties
    //you can not write any explicit constructors inside interface
    //no static member inside interface

    //naming convention of interface: must start with uppercase I
    //followed by the name of the interface in Pascal style
    //access specifiers for an interface: public and internal
    //public interface IDataAccess
    internal interface IDataAccess
    {
        //members are by default public
        //members are by default abstract
        void GetData();
        string Data { get; }
    }
}