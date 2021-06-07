Feature: Predict viral escape
[Viral mutations] that evade [neutralizing antibodies], an occurrence known as [viral escape], 
can occur and may impede [the development of vaccines]. 
To predict which mutations may lead to [viral escape], 
Hie et al. used a machine learning technique for natural language processing with two components: 
grammar (or syntax) and meaning (or semantics) (see the Perspective by Kim and Przytycka). 

Three [different unsupervised language models] were constructed for 
influenza A hemagglutinin, 
HIV-1 envelope glycoprotein, and 
severe acute respiratory syndrome coronavirus 2 (SARS-CoV-2) spike glycoprotein. 
[Semantic landscapes] for these viruses predicted [viral escape mutations] 
that produce [sequences] that are [syntactically and/or grammatically correct] 
but [effectively different in semantics] and thus able to [evade the immune system].


The ability for viruses to mutate and evade the human immune system and cause infection, called [viral escape], 
remains an obstacle to [antiviral and vaccine development]. 
Understanding the complex rules that govern escape could inform [therapeutic design]. 
We modeled [viral escape] with machine learning algorithms originally developed for human natural language. 
We identified [escape mutations] as those 
that preserve [viral infectivity] but cause a virus to [look different to the immune system], 
akin to [word changes] that preserve [a sentence’s grammaticality] but [change its meaning]. 
With this approach, language models of 
[influenza hemagglutinin], 
[HIV-1 envelope glycoprotein (HIV Env)], and 
severe acute respiratory syndrome coronavirus 2 (SARS-CoV-2) Spike viral proteins 
can accurately predict [structural escape patterns] using [sequence data] alone. 
Our study represents a promising conceptual bridge between [natural language] and [viral evolution].

@mytag
Scenario: predict [structural escape patterns] using [sequence data]
	Given viral evolution generates the following structral patterns of sequence data:
	| Syntax		| Semantics	|
	| correct		| effectively different	|
	| correct		| effectively same		|
	| correct		| ineffective			|
	| incorrect		| ineffective			|
	When the structral patterns of sequence data are predicted
	Then the prediction result should be as follows:
	| Prediction Result	|
	| viral escape		|
	| no viral escape	|
	| no viral escape	|
	| no viral escape	|


