// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Runtime.Serialization;
using System.Collections;

namespace BrokeredPointOfService
{
    public interface NetfxException 
    {
        // Summary:
        //     Gets a collection of key/value pairs that provide additional user-defined
        //     information about the exception.
        //
        // Returns:
        //     An object that implements the System.Collections.IDictionary interface and
        //     contains a collection of user-defined key/value pairs. The default is an
        //     empty collection.
        System.Collections.Generic.IDictionary<string, string> Data { get; }
        //
        // Summary:
        //     Gets or sets a link to the help file associated with this exception.
        //
        // Returns:
        //     The Uniform Resource Name (URN) or Uniform Resource Locator (URL).
        string HelpLink { get; set; }
        //
        // Summary:
        //     Gets or sets HRESULT, a coded numerical value that is assigned to a specific
        //     exception.
        //
        // Returns:
        //     The HRESULT value.
        int HResult { get; }
        //
        // Summary:
        //     Gets the System.Exception instance that caused the current exception.
        //
        // Returns:
        //     An instance of Exception that describes the error that caused the current
        //     exception. The InnerException property returns the same value as was passed
        //     into the constructor, or a null reference (Nothing in Visual Basic) if the
        //     inner exception value was not supplied to the constructor. This property
        //     is read-only.
       NetfxException InnerException { get; }
        //
        // Summary:
        //     Gets a message that describes the current exception.
        //
        // Returns:
        //     The error message that explains the reason for the exception, or an empty
        //     string("").
        string Message { get; }
        //
        // Summary:
        //     Gets or sets the name of the application or the object that causes the error.
        //
        // Returns:
        //     The name of the application or the object that causes the error.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     The object must be a runtime System.Reflection object
        string Source { get; set; }
        //
        // Summary:
        //     Gets a string representation of the immediate frames on the call stack.
        //
        // Returns:
        //     A string that describes the immediate frames of the call stack.
        string StackTrace { get; }
        //
        // Summary:
        //     Gets the method that throws the current exception.
        //
        // Returns:
        //     The System.Reflection.MethodBase that threw the current exception.
        //System.Reflection.MethodBase TargetSite { get; }

        // Summary:
        //     Occurs when an exception is serialized to create an exception state object
        //     that contains serialized data about the exception.
        //event EventHandler<SafeSerializationEventArgs> SerializeObjectState;

        // Summary:
        //     When overridden in a derived class, returns the System.Exception that is
        //     the root cause of one or more subsequent exceptions.
        //
        // Returns:
        //     The first exception thrown in a chain of exceptions. If the System.Exception.InnerException
        //     property of the current exception is a null reference (Nothing in Visual
        //     Basic), this property returns the current exception.
        NetfxException GetBaseException();
        //
        // Summary:
        //     When overridden in a derived class, sets the System.Runtime.Serialization.SerializationInfo
        //     with information about the exception.
        //
        // Parameters:
        //   info:
        //     The System.Runtime.Serialization.SerializationInfo that holds the serialized
        //     object data about the exception being thrown.
        //
        //   context:
        //     The System.Runtime.Serialization.StreamingContext that contains contextual
        //     information about the source or destination.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The info parameter is a null reference (Nothing in Visual Basic).
        //void GetObjectData(SerializationInfo info, StreamingContext context);
        //
        // Summary:
        //     Gets the runtime type of the current instance.
        //
        // Returns:
        //     A System.Type object that represents the exact runtime type of the current
        //     instance.
        Type GetType();
        //
        // Summary:
        //     Creates and returns a string representation of the current exception.
        //
        // Returns:
        //     A string representation of the current exception.
        string ToString();
    }
}
