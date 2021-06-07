Feature: Appier
	來自加拿大的人工智慧平台「BlueDot」能掃描來自上百種管道的資料，並於2019年12月時偵測到中國的武漢市出現疑似肺炎的群聚感染。
	該平台也能讀取人們的[旅遊模式]和[移動軌跡]，讓初期的研究人員得以預測傳染病[可能散播的路徑與方式]。

	[Public corpora] help to remove the burden of [corpus creation].
	[Shared community annotations] contribute to addressing the challenges of [data enrichment and annotation].
	[Shared Tasks] help to promote faster [evaluation process] and serve as [a source of annotated data].

	Four Components: 
	Text mining corpora, 
	Text mining modeling resources
	Text mining systems
	Shared tasks
	
	We note standout systems that either 
	provide strong performance on fundamental tasks such as [search] or [question answering (QA)] or 
	provide novel functionality such as [multi-document summarization] or [linking between articles and clinical trials]. 
	
	1.[Embeddings] are computed [vector representations of spans of text] 
	that capture [semantic and syntactic similarities] between these texts.
	2.[Annotations] provide information in addition to the metadata and text of the COVID-19 literature. 
	One may wish to [identify and annotate] mentions of biomedical or clinical [entities], [relations], or [attributes] 
	of interest in the paper text.
	3.[Knowledge graphs] can also support [automated reasoning and inference] and 
	the potential [discovery of novel relationships].
	4.[Contextual language models] are ubiquitous in modern text mining systems.

	1.[Exploration]: provide a predefined set of [topics] or [keyphrases] with which to filter the documents. . 
	[Topics] or [keyphrases] can be extracted from documents using [supervised] or [unsupervised] biomedical entity extraction.
	2.[QA systems] accept queries in the form of questions and provide extracted answer spans from documents, 
	with the ability to [generate summaries across answers], or [ask follow-up questions].
	3.[KB construction] describes systems that create KBs by extracting [entities and relations] from text. 
	KB system links papers to their corresponding [clinical trials and trial results].
	4.[Visualizations] are usually coupled with [extracted KBs] or [citation networks].


@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120