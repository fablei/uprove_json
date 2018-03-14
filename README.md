# U-Prove JSONs
Please note that this repository is a result of the Master Thesis of the author at the BFH [8]. Newcomer and interested programmers, pls see the "Contributing" chapter as well.

U-Prove JSON represents the objects from the U-Prove Cryptographic Specification V1.1 Revision 3 [1]. It is useful for serializing and deserializing the U-Prove objects to send them over the network. E.g. between Issuer and Prover. Additionally it contains new objects created by the U-Prove Extension [2] or the authors self implementations (Prover [3], Issuer [4] and Verifier [5]). 

## Getting Started
Get yourself a local copy of this repository and open the solution file (uprove_json.sln) in a Visual Studio 2015 (or a more recent version).

### Prerequisites
Before building the project, install the following dependencies:
* 	UProveCrypto [6] (Apache License Version 2.0)
* 	Newtonsoft.JSON [7] (MIT license)
* 	bc-trimmed [6] (Bouncy Castle License)

### Installing
* 	UProveCrypto and bc-trimmed
	You need to download and build the uprove-extension-csharp-sdk_fork [6] and include the build dependencies in the project.
* 	Newtonsoft.JSON
	Open the Paket-Manager-Console and execute the following command (for further details, pls visit the official project webpage [7])
	```
	PM> Install-Package Newtonsoft.Json
	```

## Running the tests
In the "Test" menu of Visual Studio, select the "All Tests" from the "Run" submenu item. Note that a complete test run takes some time to complete. If you want to extend the tests, feel free to edit the "uprove_json_tests" project in the Visual Studio.

## Contributing
Contributors are always welcome. As information about U-Prove is only spread found the official webpage from Microsoft, I would like to build up a little community which is working with U-Prove and helps newcomer to get in touch easily. To do so, it would be nice if you could open a new "issue" at this [page](https://github.com/fablei/uprove_json/issues) and select as kind -> task and fill in your project link.

If you're brand-new to the project and run into any blockers or problems, please open an [issue on this repository](https://github.com/fablei/uprove_json/issues) and I would love to help you fix it for you


## Author
* 	Bojan Leimer


## References

[1] https://www.microsoft.com/en-us/research/publication/u-prove-cryptographic-specification-v1-1-revision-3/

[2] https://github.com/fablei/uprove-extension-csharp-sdk or https://www.microsoft.com/en-us/research/publication/u-prove-extensions/

[3] repo prover comming soon

[4] repo issuer comming soon

[5] repo verifier comming soon

[6] https://github.com/fablei/uprove-csharp-sdk

[7] https://www.newtonsoft.com/json

[8] https://www.ti.bfh.ch/de/master/msc_engineering.html