#pragma checksum "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4290ef5b81c162280e0dbeda37e3dfb1836f061e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace increaser.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using increaser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\_Imports.razor"
using increaser.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using EthereumSmartContracts.Contracts.SimpleStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using EthereumSmartContracts.Contracts.SimpleStorage.ContractDefinition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using Nethereum.Web3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using Nethereum.Web3.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
using System.Numerics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\gaelb\Documents\Dev\NethereumCodeGenDemo\increaser\Pages\Counter.razor"
       

    BigInteger currentStoredValue = 0;

    public async Task storeNewNumber()
    {
        var url = "https://rinkeby.infura.io/v3/7238211010344719ad14a89db874158c";
        var privateKey = "0x7580e7fb49df1c861f0050fae31c2224c6aba908e116b8da44ee8cd927b990b0";
        var account = new Account(privateKey);
        var web3 = new Web3(account, url);
        //  An already-deployed SimpleStorage.sol contract on Rinkeby:
        var contractAddress = "0xb52Fe7D1E04fbf47918Ad8d868103F03Da6ec4fE";
        var service = new SimpleStorageService(web3, contractAddress);
        // Get the stored value
        currentStoredValue = await service.GetQueryAsync();
        //   var increaseValue = await service.SetRequestAndWaitForReceiptAsync(300000000);
        //   Get the stored value
        //  var currentStoredValue = await service.GetQueryAsync();
        //  Console.WriteLine($"Contract has value stored: {currentStoredValue}");
        Console.WriteLine(currentStoredValue);
        // var service = SimpleStorageService.
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
