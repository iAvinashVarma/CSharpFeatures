# CSharpFeatures

CSharpFeatures contains group of C# version features, features evolved from C# 3 to till date.

![apm](https://img.shields.io/apm/l/vim-mode.svg)
[![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/iAvinashVarma) [![Twitter Follow](https://img.shields.io/twitter/follow/iAvinashVarma.svg?style=social&label=Follow)](https://twitter.com/iAvinashVarma)
![GitHub followers](https://img.shields.io/github/followers/iAvinashVarma.svg?style=flat-square&label=Follow)
<<<<<<< HEAD
[![Build status](https://avvarma.visualstudio.com/ProgLan/_apis/build/status/CSharpFeatures?branchName=master)](https://avvarma.visualstudio.com/ProgLan/_build/latest?definitionId=11)
=======
[![Build status](https://avvarma.visualstudio.com/ProgLan/_apis/build/status/CSharpFeatures?branchName=5.0)](https://avvarma.visualstudio.com/ProgLan/_build/latest?definitionId=11)
>>>>>>> 945648b6ab20fcd807f77dc269e65f663baf1e4a
[![Feature Requests](https://img.shields.io/github/issues/iAvinashVarma/CSharpFeatures/feature-request.svg)](https://github.com/iAvinashVarma/CSharpFeatures/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/iAvinashVarma/CSharpFeatures/bug.svg)](https://github.com/iAvinashVarma/CSharpFeatures/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)

---

## IDE

Visual Studio 2017

---

## .NET Framework

v4.6.1

---

## C# Evolution Matrix

<table>
    <tr>
        <th>C# Version</th>
        <th>CLR Version</th>
        <th>.NET Framework</th>
		<th>Version / IDE</th>
        <th>Features</th>
        <th>Available Here</th>
    </tr>
    <tr>
        <td>1.0</td>
        <td>1.0/1.1</td>
        <td>1.0/1.1</td>
		<td>VS2002</td>
        <td>Managed Code</td>
        <td>No</td>
    </tr>
    <tr>
        <td rowspan="6">2.0</td>
        <td rowspan="6">2.0</td>
        <td rowspan="6">2.0</td>
		<td rowspan="6">VS2005</td>
        <td>Generics</td>
        <td rowspan="6">No</td>
    </tr>
    <tr>
        <td>Partial types</td>
    </tr>
    <tr>
        <td>Anonymous Method</td>
    </tr>
    <tr>
        <td>Nullable Types</td>
    </tr>
    <tr>
        <td>Iterators</td>
    </tr>
    <tr>
        <td>Covariance and contravariance</td>
    </tr>
    <tr>
        <td rowspan="7">3.0</td>
        <td rowspan="7">2.0</td>
        <td rowspan="7">3.0\3.5</td>
		<td rowspan="7">VS2008</td>
        <td>Lambda Expressions</td>
        <td rowspan="7">No</td>
    </tr>
    <tr>
        <td>Auto-implemented properties</td>
    </tr>
    <tr>
        <td>Extension Methods</td>
    </tr>
    <tr>
        <td>Expression Tree</td>
    </tr>
    <tr>
        <td>Anonymous Types</td>
    </tr>
    <tr>
        <td>LINQ</td>
    </tr>
    <tr>
        <td>Implicit Typing (var)</td>
    </tr>
    <tr>
        <td rowspan="5">4.0</td>
        <td rowspan="5">4.0</td>
        <td rowspan="5">4.0</td>
		<td rowspan="5">VS2010</td>
        <td>Late Binding (dynamic)</td>
        <td rowspan="5">Yes</td>
    </tr>
    <tr>
        <td>Named Arguments</td>
    </tr>
    <tr>
        <td>Optional Parameters</td>
    </tr>
    <tr>
        <td>Generic covariant and contravariant</td>
    </tr>
    <tr>
        <td>Embedded interop types</td>
    </tr>
    <tr>
        <td rowspan="2">5.0</td>
        <td rowspan="2">4.0</td>
        <td rowspan="2">4.5, 4.5.1, 4.5.2</td>
		<td rowspan="2">VS2012/VS2013</td>
        <td>Async Feature</td>
        <td rowspan="2">No</td>
    </tr>
    <tr>
        <td>Caller Information</td>
    </tr>
    <tr>
        <td rowspan="8">6.0</td>
        <td rowspan="8">4.0</td>
        <td rowspan="8">4.6, 4.6.1, 4.6.2</td>
		<td rowspan="8">VS2013/VS2015</td>
        <td>Static imports</td>
        <td rowspan="8">No</td>
    </tr>
    <tr>
        <td>Exception filters</td>
    </tr>
    <tr>
        <td>Property initializers</td>
    </tr>
    <tr>
        <td>Expression bodied members</td>
    </tr>
    <tr>
        <td>Null propagator</td>
    </tr>
    <tr>
        <td>String interpolation</td>
    </tr>
    <tr>
        <td>nameof operator</td>
    </tr>
    <tr>
        <td>Dictionary initializer</td>
    </tr>
    <tr>
        <td rowspan="7">7.0</td>
        <td rowspan="7">4.0</td>
        <td rowspan="7">4.7, 4.7.1, 4.7.2</td>
		<td rowspan="7">VS2017</td>
        <td>Improved performance and productivity</td>
        <td rowspan="7">No</td>
    </tr>
    <tr>
        <td>Azure Support</td>
    </tr>
    <tr>
        <td>AI Support</td>
    </tr>
    <tr>
        <td>Game development</td>
    </tr>
    <tr>
        <td>Cross platform</td>
    </tr>
    <tr>
        <td>Mobile App Development</td>
    </tr>
    <tr>
        <td>Window App Development</td>
    </tr>
    <tr>
        <td rowspan="8">8.0</td>
        <td rowspan="8">4.0</td>
        <td rowspan="8">4.8</td>
		<td rowspan="8">VS2019</td>
        <td>Nullable reference types</td>
        <td rowspan="8">No</td>
    </tr>
    <tr>
        <td>Async streams</td>
    </tr>
    <tr>
        <td>Implicitly typed new-expressions</td>
    </tr>
    <tr>
        <td>Ranges and indices</td>
    </tr>
    <tr>
        <td>Default interface members</td>
    </tr>
    <tr>
        <td>Recursive patterns</td>
    </tr>
    <tr>
        <td>Switch expressions</td>
    </tr>
    <tr>
        <td>Platform dependencies</td>
    </tr>
</table>​