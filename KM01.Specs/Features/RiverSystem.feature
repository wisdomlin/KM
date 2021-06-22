Feature: river system


@mytag
Scenario: river system
在一河川上游將飽和食鹽水以 30 (cm)^(3)*(s)^(-1)之流率注入河水中，
在下游採取河水進行水質分析，得知水 1000 (cm)^(3) 之中混有 40 mg 的食鹽。
若上游不含鹽分，且此河段間無支流流入及流出，試問河川之流量為多少 cms?
假設飽和食鹽水 1,000 (cm)^(3)中可溶解食鹽 350 g。
	Given Qs is 3E-5
	And Cs is 3.5E2
	And Co is 4E-2
	When river system gets in steady state
	Then Qi is 2.6247E-1


