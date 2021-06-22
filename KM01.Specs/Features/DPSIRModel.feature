Feature: DPSIRModel
	Simple calculator for adding two numbers

@mytag
Scenario: search and decide
	Given Drivers, Pressures, States, Impacts, and Responses have random indicator value initially
	And Drivers, Pressures, States, Impacts, and Responses have random relationships initially
	When Responses search and decide
	Then the overall benefit of chosen indicator value should be greater than those of others
