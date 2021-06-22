Feature: Blinded Experiment

[高端] 與 [臨床試驗中心] 皆在[盲性狀態]下，交由第三方單位 [臨床試驗受託機構 (CRO)] 進行資料清理。
在期間分析 (Interim Analysis) 進行解盲作業，評估資料包括[疫苗安全性]與[中和抗體濃度]，
並召開 [獨立資料監視委員會 (Independent Data Monitoring Committee, IDMC)]。

@mytag
Scenario: before unblind
	When clinical (contract) research organization starts doing data analysis
	Then pharmaceutical company and clinical trial center are blinded

@mytag
Scenario: after unblind (Interim Analysis)
	When clinical research organization finishes doing data analysis
	Then independent data monitoring committee is set up
	And vaccine safety and neutralizing nntibody value are provided

