#region License
//
// ValueRequiredException.cs July 2006
//
// Copyright (C) 2006, Niall Gallagher <niallg@users.sf.net>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied. See the License for the specific language governing
// permissions and limitations under the License.
//
#endregion
#region Using directives
using System;
#endregion
namespace SimpleFramework.Xml.Core {
   /// <summary>
   /// The <c>ValueRequiredException</c> is thrown when an attribute
   /// or element is missing from the XML document. This is thrown only if
   /// the attribute or element is required according to the annotation
   /// for that field within the XML schema class.
   /// </summary>
   public class ValueRequiredException : PersistenceException {
      /// <summary>
      /// Constructor for the <c>ValueRequiredException</c> object.
      /// This constructor takes a format string an a variable number of
      /// object arguments, which can be inserted into the format string.
      /// </summary>
      /// <param name="text">
      /// a format string used to present the error message
      /// </param>
      /// <param name="list">
      /// a list of arguments to insert into the string
      /// </param>
      public ValueRequiredException(String text, Object... list) {
         super(text, list);
      }
      /// <summary>
      /// Constructor for the <c>ValueRequiredException</c> object.
      /// This constructor takes a format string an a variable number of
      /// object arguments, which can be inserted into the format string.
      /// </summary>
      /// <param name="cause">
      /// the source exception this is used to represent
      /// </param>
      /// <param name="text">
      /// a format string used to present the error message
      /// </param>
      /// <param name="list">
      /// a list of arguments to insert into the string
      /// </param>
      public ValueRequiredException(Throwable cause, String text, Object... list) {
         super(cause, text, list);
      }
   }
}
