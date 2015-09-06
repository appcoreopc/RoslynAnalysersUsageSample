using System;
using System.Diagnostics.CodeAnalysis;

namespace AnotherClassLibrary
{
public class Car
{

    private string _model;

    [SuppressMessage("Potential Code Quality Issues", 
                        "RECS0022:A catch clause that catches System.Exception and has an empty body", 
                        Justification = "This is an explanation why I have suppressed this warning.")]
    void Start()
    {
        try {
            throw new NotSupportedException();
        } catch { // warning here, becase the catch is empty
        }
    }
}
}
