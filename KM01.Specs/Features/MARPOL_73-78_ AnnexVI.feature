Feature: MARPOL 73/78 - Annex VI

國際海事組織 (IMO) 在 2016 年加強了 NOx 排放標準， 2020 年又加強了 SOx 排放標準，2023 年將再加強 碳排放標準。
這個碳排新標準主要用兩種指標來要求: 一是 [船舶能效指數 (EEXI)]，二是 [碳强度指数(CII)]。
目前符合這兩指標要求的船支並不多，除非是新型的節能船。
如果舊船想要符合這兩個指標要求，就必須降低船速，或是降低主機功率。
但是在海上降低船速，可能要會造成安全性、耗油、碳排增加等問題，而且運輸量能降低又進一步加劇了目前缺船的問題。

所以，藉由這個交通運輸案例，我想再一次提醒節能減碳的重要性，只要我們認為對的事情，就提早做預備、勇敢做投資。
事實上，我看到我們有提供未來航運趨勢預估量，其實只要把這些運輸需求量乘上轉換係數，就可以知道全世界需要多少節能船，這就可以形成我們永續投資的標準和策略。

@mytag
Scenario: NOx 
Total weighted cycle emission limit (g/kWh)
	Given the ship status :
	| ship construction date	| engine' s rated speed	|
	| 2000.01.01				| 129					|
	| 2000.01.01				| 130					|
	| 2000.01.01				| 720					|
	| 2000.01.01				| 1999					|
	| 2000.01.01				| 2000					|
	| 2011.01.01				| 129					|
	| 2011.01.01				| 130					|
	| 2011.01.01				| 720					|
	| 2011.01.01				| 1999					|
	| 2011.01.01				| 2000					|
	| 2016.01.01				| 129					|
	| 2016.01.01				| 130					|
	| 2016.01.01				| 720					|
	| 2016.01.01				| 1999					|
	| 2016.01.01				| 2000					|
	When the Total weighted cycle emission limit is asked
	Then Total weighted cycle emission limit should be as follows:
	| total weighted cycle emission limit	|
	| 17.0									|
	| 17.0									|
	| 12.1									|
	| 9.8									|
	| 9.8									|
	| 14.4									|
	| 14.4									|
	| 9.7									|
	| 7.7									|
	| 7.7									|
	| 3.4									|
	| 3.4									|
	| 2.4									|
	| 2.0									|
	| 2.0									|
	
@mytag
Scenario: SOx
	When clinical research organization finishes doing data analysis
	Then independent data monitoring committee is set up
	And vaccine safety and neutralizing nntibody value are provided

@mytag
Scenario: Carbon Emission	
	When clinical (contract) research organization starts doing data analysis
	Then pharmaceutical company and clinical trial center are blinded
