/**namespace:Aggregations.Bucket.DateHistogram */
var DateInterval;
(function (DateInterval) {
    DateInterval[DateInterval["second"] = 0] = "second";
    DateInterval[DateInterval["minute"] = 1] = "minute";
    DateInterval[DateInterval["hour"] = 2] = "hour";
    DateInterval[DateInterval["day"] = 3] = "day";
    DateInterval[DateInterval["week"] = 4] = "week";
    DateInterval[DateInterval["month"] = 5] = "month";
    DateInterval[DateInterval["quarter"] = 6] = "quarter";
    DateInterval[DateInterval["year"] = 7] = "year";
})(DateInterval || (DateInterval = {}));
/**namespace:Analysis.Languages */
var Language;
(function (Language) {
    Language[Language["Arabic"] = 0] = "Arabic";
    Language[Language["Armenian"] = 1] = "Armenian";
    Language[Language["Basque"] = 2] = "Basque";
    Language[Language["Brazilian"] = 3] = "Brazilian";
    Language[Language["Bulgarian"] = 4] = "Bulgarian";
    Language[Language["Catalan"] = 5] = "Catalan";
    Language[Language["Chinese"] = 6] = "Chinese";
    Language[Language["Cjk"] = 7] = "Cjk";
    Language[Language["Czech"] = 8] = "Czech";
    Language[Language["Danish"] = 9] = "Danish";
    Language[Language["Dutch"] = 10] = "Dutch";
    Language[Language["English"] = 11] = "English";
    Language[Language["Finnish"] = 12] = "Finnish";
    Language[Language["French"] = 13] = "French";
    Language[Language["Galician"] = 14] = "Galician";
    Language[Language["German"] = 15] = "German";
    Language[Language["Greek"] = 16] = "Greek";
    Language[Language["Hindi"] = 17] = "Hindi";
    Language[Language["Hungarian"] = 18] = "Hungarian";
    Language[Language["Indonesian"] = 19] = "Indonesian";
    Language[Language["Irish"] = 20] = "Irish";
    Language[Language["Italian"] = 21] = "Italian";
    Language[Language["Latvian"] = 22] = "Latvian";
    Language[Language["Norwegian"] = 23] = "Norwegian";
    Language[Language["Persian"] = 24] = "Persian";
    Language[Language["Portuguese"] = 25] = "Portuguese";
    Language[Language["Romanian"] = 26] = "Romanian";
    Language[Language["Russian"] = 27] = "Russian";
    Language[Language["Sorani"] = 28] = "Sorani";
    Language[Language["Spanish"] = 29] = "Spanish";
    Language[Language["Swedish"] = 30] = "Swedish";
    Language[Language["Turkish"] = 31] = "Turkish";
    Language[Language["Thai"] = 32] = "Thai";
})(Language || (Language = {}));
/**namespace:Analysis.Languages */
var SnowballLanguage;
(function (SnowballLanguage) {
    SnowballLanguage[SnowballLanguage["Armenian"] = 0] = "Armenian";
    SnowballLanguage[SnowballLanguage["Basque"] = 1] = "Basque";
    SnowballLanguage[SnowballLanguage["Catalan"] = 2] = "Catalan";
    SnowballLanguage[SnowballLanguage["Danish"] = 3] = "Danish";
    SnowballLanguage[SnowballLanguage["Dutch"] = 4] = "Dutch";
    SnowballLanguage[SnowballLanguage["English"] = 5] = "English";
    SnowballLanguage[SnowballLanguage["Finnish"] = 6] = "Finnish";
    SnowballLanguage[SnowballLanguage["French"] = 7] = "French";
    SnowballLanguage[SnowballLanguage["Ferman"] = 8] = "Ferman";
    SnowballLanguage[SnowballLanguage["German2"] = 9] = "German2";
    SnowballLanguage[SnowballLanguage["Hungarian"] = 10] = "Hungarian";
    SnowballLanguage[SnowballLanguage["Italian"] = 11] = "Italian";
    SnowballLanguage[SnowballLanguage["Kp"] = 12] = "Kp";
    SnowballLanguage[SnowballLanguage["Lovins"] = 13] = "Lovins";
    SnowballLanguage[SnowballLanguage["Norwegian"] = 14] = "Norwegian";
    SnowballLanguage[SnowballLanguage["Porter"] = 15] = "Porter";
    SnowballLanguage[SnowballLanguage["Portuguese"] = 16] = "Portuguese";
    SnowballLanguage[SnowballLanguage["Romanian"] = 17] = "Romanian";
    SnowballLanguage[SnowballLanguage["Russian"] = 18] = "Russian";
    SnowballLanguage[SnowballLanguage["Spanish"] = 19] = "Spanish";
    SnowballLanguage[SnowballLanguage["Swedish"] = 20] = "Swedish";
    SnowballLanguage[SnowballLanguage["Turkish"] = 21] = "Turkish";
})(SnowballLanguage || (SnowballLanguage = {}));
/**namespace:Analysis.TokenFilters.DelimitedPayload */
var DelimitedPayloadEncoding;
(function (DelimitedPayloadEncoding) {
    DelimitedPayloadEncoding[DelimitedPayloadEncoding["int"] = 0] = "int";
    DelimitedPayloadEncoding[DelimitedPayloadEncoding["float"] = 1] = "float";
    DelimitedPayloadEncoding[DelimitedPayloadEncoding["identity"] = 2] = "identity";
})(DelimitedPayloadEncoding || (DelimitedPayloadEncoding = {}));
/**namespace:Analysis.TokenFilters.EdgeNGram */
var EdgeNGramSide;
(function (EdgeNGramSide) {
    EdgeNGramSide[EdgeNGramSide["front"] = 0] = "front";
    EdgeNGramSide[EdgeNGramSide["back"] = 1] = "back";
})(EdgeNGramSide || (EdgeNGramSide = {}));
/**namespace:Analysis.TokenFilters.Phonetic */
var PhoneticEncoder;
(function (PhoneticEncoder) {
    PhoneticEncoder[PhoneticEncoder["metaphone"] = 0] = "metaphone";
    PhoneticEncoder[PhoneticEncoder["doublemetaphone"] = 1] = "doublemetaphone";
    PhoneticEncoder[PhoneticEncoder["soundex"] = 2] = "soundex";
    PhoneticEncoder[PhoneticEncoder["refinedsoundex"] = 3] = "refinedsoundex";
    PhoneticEncoder[PhoneticEncoder["caverphone1"] = 4] = "caverphone1";
    PhoneticEncoder[PhoneticEncoder["caverphone2"] = 5] = "caverphone2";
    PhoneticEncoder[PhoneticEncoder["cologne"] = 6] = "cologne";
    PhoneticEncoder[PhoneticEncoder["nysiis"] = 7] = "nysiis";
    PhoneticEncoder[PhoneticEncoder["koelnerphonetik"] = 8] = "koelnerphonetik";
    PhoneticEncoder[PhoneticEncoder["haasephonetik"] = 9] = "haasephonetik";
    PhoneticEncoder[PhoneticEncoder["beidermorse"] = 10] = "beidermorse";
})(PhoneticEncoder || (PhoneticEncoder = {}));
/**namespace:Analysis.TokenFilters.Synonym */
var SynonymFormat;
(function (SynonymFormat) {
    SynonymFormat[SynonymFormat["solr"] = 0] = "solr";
    SynonymFormat[SynonymFormat["wordnet"] = 1] = "wordnet";
})(SynonymFormat || (SynonymFormat = {}));
/**namespace:Analysis.Tokenizers.NGram */
var TokenChar;
(function (TokenChar) {
    TokenChar[TokenChar["letter"] = 0] = "letter";
    TokenChar[TokenChar["digit"] = 1] = "digit";
    TokenChar[TokenChar["whitespace"] = 2] = "whitespace";
    TokenChar[TokenChar["punctuation"] = 3] = "punctuation";
    TokenChar[TokenChar["symbol"] = 4] = "symbol";
})(TokenChar || (TokenChar = {}));
/**namespace:CommonOptions.TimeUnit */
var TimeUnit;
(function (TimeUnit) {
    TimeUnit[TimeUnit["ms"] = 0] = "ms";
    TimeUnit[TimeUnit["s"] = 1] = "s";
    TimeUnit[TimeUnit["m"] = 2] = "m";
    TimeUnit[TimeUnit["h"] = 3] = "h";
    TimeUnit[TimeUnit["d"] = 4] = "d";
    TimeUnit[TimeUnit["w"] = 5] = "w";
    TimeUnit[TimeUnit["M"] = 6] = "M";
    TimeUnit[TimeUnit["y"] = 7] = "y";
})(TimeUnit || (TimeUnit = {}));
/**namespace:Mapping */
var SimilarityOption;
(function (SimilarityOption) {
    SimilarityOption[SimilarityOption["default"] = 0] = "default";
    SimilarityOption[SimilarityOption["BM25"] = 1] = "BM25";
})(SimilarityOption || (SimilarityOption = {}));
/**namespace:Mapping */
var DynamicMapping;
(function (DynamicMapping) {
    DynamicMapping[DynamicMapping["allow"] = 0] = "allow";
    DynamicMapping[DynamicMapping["ignore"] = 1] = "ignore";
    DynamicMapping[DynamicMapping["strict"] = 2] = "strict";
})(DynamicMapping || (DynamicMapping = {}));
/**namespace:Search.Search.Sort */
var SortOrder;
(function (SortOrder) {
    SortOrder[SortOrder["asc"] = 0] = "asc";
    SortOrder[SortOrder["desc"] = 1] = "desc";
})(SortOrder || (SortOrder = {}));
/**namespace:Search.Search.Sort */
var SortMode;
(function (SortMode) {
    SortMode[SortMode["min"] = 0] = "min";
    SortMode[SortMode["max"] = 1] = "max";
    SortMode[SortMode["sum"] = 2] = "sum";
    SortMode[SortMode["avg"] = 3] = "avg";
})(SortMode || (SortMode = {}));
/**namespace:Search.Search.Highlighting */
var HighlighterType;
(function (HighlighterType) {
    HighlighterType[HighlighterType["plain"] = 0] = "plain";
    HighlighterType[HighlighterType["postings"] = 1] = "postings";
    HighlighterType[HighlighterType["fvh"] = 2] = "fvh";
})(HighlighterType || (HighlighterType = {}));
/**namespace:Search.Search.Rescoring */
var ScoreMode;
(function (ScoreMode) {
    ScoreMode[ScoreMode["avg"] = 0] = "avg";
    ScoreMode[ScoreMode["first"] = 1] = "first";
    ScoreMode[ScoreMode["max"] = 2] = "max";
    ScoreMode[ScoreMode["min"] = 3] = "min";
    ScoreMode[ScoreMode["multiply"] = 4] = "multiply";
    ScoreMode[ScoreMode["total"] = 5] = "total";
    ScoreMode[ScoreMode["sum"] = 6] = "sum";
})(ScoreMode || (ScoreMode = {}));
/**namespace:QueryDsl.MultiTermQueryRewrite */
var RewriteMultiTerm;
(function (RewriteMultiTerm) {
    RewriteMultiTerm[RewriteMultiTerm["constant_score"] = 0] = "constant_score";
    RewriteMultiTerm[RewriteMultiTerm["scoring_boolean"] = 1] = "scoring_boolean";
    RewriteMultiTerm[RewriteMultiTerm["constant_score_boolean"] = 2] = "constant_score_boolean";
    RewriteMultiTerm[RewriteMultiTerm["top_terms_N"] = 3] = "top_terms_N";
    RewriteMultiTerm[RewriteMultiTerm["top_terms_boost_N"] = 4] = "top_terms_boost_N";
    RewriteMultiTerm[RewriteMultiTerm["top_terms_blended_freqs_N"] = 5] = "top_terms_blended_freqs_N";
})(RewriteMultiTerm || (RewriteMultiTerm = {}));
/**namespace:QueryDsl.FullText.MultiMatch */
var TextQueryType;
(function (TextQueryType) {
    TextQueryType[TextQueryType["best_fields"] = 0] = "best_fields";
    TextQueryType[TextQueryType["most_fields"] = 1] = "most_fields";
    TextQueryType[TextQueryType["cross_fields"] = 2] = "cross_fields";
    TextQueryType[TextQueryType["phrase"] = 3] = "phrase";
    TextQueryType[TextQueryType["phrase_prefix"] = 4] = "phrase_prefix";
})(TextQueryType || (TextQueryType = {}));
/**namespace:QueryDsl */
var Operator;
(function (Operator) {
    Operator[Operator["and"] = 0] = "and";
    Operator[Operator["or"] = 1] = "or";
})(Operator || (Operator = {}));
/**namespace:QueryDsl.FullText.MultiMatch */
var ZeroTermsQuery;
(function (ZeroTermsQuery) {
    ZeroTermsQuery[ZeroTermsQuery["all"] = 0] = "all";
    ZeroTermsQuery[ZeroTermsQuery["none"] = 1] = "none";
})(ZeroTermsQuery || (ZeroTermsQuery = {}));
/**namespace:QueryDsl.Joining.HasChild */
var ChildScoreMode;
(function (ChildScoreMode) {
    ChildScoreMode[ChildScoreMode["none"] = 0] = "none";
    ChildScoreMode[ChildScoreMode["avg"] = 1] = "avg";
    ChildScoreMode[ChildScoreMode["sum"] = 2] = "sum";
    ChildScoreMode[ChildScoreMode["max"] = 3] = "max";
    ChildScoreMode[ChildScoreMode["min"] = 4] = "min";
})(ChildScoreMode || (ChildScoreMode = {}));
/**namespace:QueryDsl.Joining.HasParent */
var ParentScoreMode;
(function (ParentScoreMode) {
    ParentScoreMode[ParentScoreMode["none"] = 0] = "none";
    ParentScoreMode[ParentScoreMode["score"] = 1] = "score";
})(ParentScoreMode || (ParentScoreMode = {}));
/**namespace:QueryDsl.FullText.SimpleQueryString */
var SimpleQueryStringFlags;
(function (SimpleQueryStringFlags) {
    SimpleQueryStringFlags[SimpleQueryStringFlags["NONE"] = 1] = "NONE";
    SimpleQueryStringFlags[SimpleQueryStringFlags["AND"] = 2] = "AND";
    SimpleQueryStringFlags[SimpleQueryStringFlags["OR"] = 4] = "OR";
    SimpleQueryStringFlags[SimpleQueryStringFlags["NOT"] = 8] = "NOT";
    SimpleQueryStringFlags[SimpleQueryStringFlags["PREFIX"] = 16] = "PREFIX";
    SimpleQueryStringFlags[SimpleQueryStringFlags["PHRASE"] = 32] = "PHRASE";
    SimpleQueryStringFlags[SimpleQueryStringFlags["PRECEDENCE"] = 64] = "PRECEDENCE";
    SimpleQueryStringFlags[SimpleQueryStringFlags["ESCAPE"] = 128] = "ESCAPE";
    SimpleQueryStringFlags[SimpleQueryStringFlags["WHITESPACE"] = 256] = "WHITESPACE";
    SimpleQueryStringFlags[SimpleQueryStringFlags["FUZZY"] = 512] = "FUZZY";
    SimpleQueryStringFlags[SimpleQueryStringFlags["NEAR"] = 1024] = "NEAR";
    SimpleQueryStringFlags[SimpleQueryStringFlags["SLOP"] = 2048] = "SLOP";
    SimpleQueryStringFlags[SimpleQueryStringFlags["ALL"] = 4096] = "ALL";
})(SimpleQueryStringFlags || (SimpleQueryStringFlags = {}));
/**namespace:QueryDsl.Joining.Nested */
var NestedScoreMode;
(function (NestedScoreMode) {
    NestedScoreMode[NestedScoreMode["avg"] = 0] = "avg";
    NestedScoreMode[NestedScoreMode["total"] = 1] = "total";
    NestedScoreMode[NestedScoreMode["max"] = 2] = "max";
    NestedScoreMode[NestedScoreMode["none"] = 3] = "none";
})(NestedScoreMode || (NestedScoreMode = {}));
/**namespace:QueryDsl.Compound.FunctionScore.Functions */
var FunctionScoreMode;
(function (FunctionScoreMode) {
    FunctionScoreMode[FunctionScoreMode["multiply"] = 0] = "multiply";
    FunctionScoreMode[FunctionScoreMode["sum"] = 1] = "sum";
    FunctionScoreMode[FunctionScoreMode["avg"] = 2] = "avg";
    FunctionScoreMode[FunctionScoreMode["first"] = 3] = "first";
    FunctionScoreMode[FunctionScoreMode["max"] = 4] = "max";
    FunctionScoreMode[FunctionScoreMode["min"] = 5] = "min";
})(FunctionScoreMode || (FunctionScoreMode = {}));
/**namespace:QueryDsl.Compound.FunctionScore.Functions */
var FunctionBoostMode;
(function (FunctionBoostMode) {
    FunctionBoostMode[FunctionBoostMode["multiply"] = 0] = "multiply";
    FunctionBoostMode[FunctionBoostMode["replace"] = 1] = "replace";
    FunctionBoostMode[FunctionBoostMode["sum"] = 2] = "sum";
    FunctionBoostMode[FunctionBoostMode["avg"] = 3] = "avg";
    FunctionBoostMode[FunctionBoostMode["max"] = 4] = "max";
    FunctionBoostMode[FunctionBoostMode["min"] = 5] = "min";
})(FunctionBoostMode || (FunctionBoostMode = {}));
/**namespace:QueryDsl.Geo.BoundingBox */
var GeoExecution;
(function (GeoExecution) {
    GeoExecution[GeoExecution["memory"] = 0] = "memory";
    GeoExecution[GeoExecution["indexed"] = 1] = "indexed";
})(GeoExecution || (GeoExecution = {}));
/**namespace:QueryDsl.Geo */
var GeoValidationMethod;
(function (GeoValidationMethod) {
    GeoValidationMethod[GeoValidationMethod["coerce"] = 0] = "coerce";
    GeoValidationMethod[GeoValidationMethod["ignore_malformed"] = 1] = "ignore_malformed";
    GeoValidationMethod[GeoValidationMethod["strict"] = 2] = "strict";
})(GeoValidationMethod || (GeoValidationMethod = {}));
/**namespace:CommonOptions.Geo */
var DistanceUnit;
(function (DistanceUnit) {
    DistanceUnit[DistanceUnit["in"] = 0] = "in";
    DistanceUnit[DistanceUnit["ft"] = 1] = "ft";
    DistanceUnit[DistanceUnit["yd"] = 2] = "yd";
    DistanceUnit[DistanceUnit["mi"] = 3] = "mi";
    DistanceUnit[DistanceUnit["nmi"] = 4] = "nmi";
    DistanceUnit[DistanceUnit["km"] = 5] = "km";
    DistanceUnit[DistanceUnit["m"] = 6] = "m";
    DistanceUnit[DistanceUnit["cm"] = 7] = "cm";
    DistanceUnit[DistanceUnit["mm"] = 8] = "mm";
})(DistanceUnit || (DistanceUnit = {}));
/**namespace:QueryDsl.Geo */
var GeoOptimizeBBox;
(function (GeoOptimizeBBox) {
    GeoOptimizeBBox[GeoOptimizeBBox["memory"] = 0] = "memory";
    GeoOptimizeBBox[GeoOptimizeBBox["indexed"] = 1] = "indexed";
    GeoOptimizeBBox[GeoOptimizeBBox["none"] = 2] = "none";
})(GeoOptimizeBBox || (GeoOptimizeBBox = {}));
/**namespace:CommonOptions.Geo */
var GeoDistanceType;
(function (GeoDistanceType) {
    GeoDistanceType[GeoDistanceType["sloppy_arc"] = 0] = "sloppy_arc";
    GeoDistanceType[GeoDistanceType["arc"] = 1] = "arc";
    GeoDistanceType[GeoDistanceType["plane"] = 2] = "plane";
})(GeoDistanceType || (GeoDistanceType = {}));
/**namespace:Aggregations.Bucket.GeoHashGrid */
var GeoHashPrecision;
(function (GeoHashPrecision) {
    GeoHashPrecision[GeoHashPrecision["Precision1"] = 1] = "Precision1";
    GeoHashPrecision[GeoHashPrecision["Precision2"] = 2] = "Precision2";
    GeoHashPrecision[GeoHashPrecision["Precision3"] = 3] = "Precision3";
    GeoHashPrecision[GeoHashPrecision["Precision4"] = 4] = "Precision4";
    GeoHashPrecision[GeoHashPrecision["Precision5"] = 5] = "Precision5";
    GeoHashPrecision[GeoHashPrecision["Precision6"] = 6] = "Precision6";
    GeoHashPrecision[GeoHashPrecision["Precision7"] = 7] = "Precision7";
    GeoHashPrecision[GeoHashPrecision["Precision8"] = 8] = "Precision8";
    GeoHashPrecision[GeoHashPrecision["Precision9"] = 9] = "Precision9";
    GeoHashPrecision[GeoHashPrecision["Precision10"] = 10] = "Precision10";
    GeoHashPrecision[GeoHashPrecision["Precision11"] = 11] = "Precision11";
    GeoHashPrecision[GeoHashPrecision["Precision12"] = 12] = "Precision12";
})(GeoHashPrecision || (GeoHashPrecision = {}));
/**namespace:Aggregations.Bucket.Terms */
var TermsAggregationExecutionHint;
(function (TermsAggregationExecutionHint) {
    TermsAggregationExecutionHint[TermsAggregationExecutionHint["map"] = 0] = "map";
    TermsAggregationExecutionHint[TermsAggregationExecutionHint["global_ordinals"] = 1] = "global_ordinals";
    TermsAggregationExecutionHint[TermsAggregationExecutionHint["global_ordinals_hash"] = 2] = "global_ordinals_hash";
    TermsAggregationExecutionHint[TermsAggregationExecutionHint["global_ordinals_low_cardinality"] = 3] = "global_ordinals_low_cardinality";
})(TermsAggregationExecutionHint || (TermsAggregationExecutionHint = {}));
/**namespace:Aggregations.Bucket.Terms */
var TermsAggregationCollectMode;
(function (TermsAggregationCollectMode) {
    TermsAggregationCollectMode[TermsAggregationCollectMode["depth_first"] = 0] = "depth_first";
    TermsAggregationCollectMode[TermsAggregationCollectMode["breadth_first"] = 1] = "breadth_first";
})(TermsAggregationCollectMode || (TermsAggregationCollectMode = {}));
/**namespace:Aggregations.Bucket.Sampler */
var SamplerAggregationExecutionHint;
(function (SamplerAggregationExecutionHint) {
    SamplerAggregationExecutionHint[SamplerAggregationExecutionHint["map"] = 0] = "map";
    SamplerAggregationExecutionHint[SamplerAggregationExecutionHint["global_ordinals"] = 1] = "global_ordinals";
    SamplerAggregationExecutionHint[SamplerAggregationExecutionHint["bytes_hash"] = 2] = "bytes_hash";
})(SamplerAggregationExecutionHint || (SamplerAggregationExecutionHint = {}));
/**namespace:Cluster */
var ClusterStatus;
(function (ClusterStatus) {
    ClusterStatus[ClusterStatus["green"] = 0] = "green";
    ClusterStatus[ClusterStatus["yellow"] = 1] = "yellow";
    ClusterStatus[ClusterStatus["red"] = 2] = "red";
})(ClusterStatus || (ClusterStatus = {}));
/**namespace:Modules.Indices.Fielddata.Numeric */
var NumericFielddataFormat;
(function (NumericFielddataFormat) {
    NumericFielddataFormat[NumericFielddataFormat["array"] = 0] = "array";
    NumericFielddataFormat[NumericFielddataFormat["doc_values"] = 1] = "doc_values";
    NumericFielddataFormat[NumericFielddataFormat["disabled"] = 2] = "disabled";
})(NumericFielddataFormat || (NumericFielddataFormat = {}));
/**namespace:Mapping */
var NonStringIndexOption;
(function (NonStringIndexOption) {
    NonStringIndexOption[NonStringIndexOption["no"] = 0] = "no";
})(NonStringIndexOption || (NonStringIndexOption = {}));
/**namespace:Mapping.Types.Core.Date */
var NumericResolutionUnit;
(function (NumericResolutionUnit) {
    NumericResolutionUnit[NumericResolutionUnit["milliseconds"] = 0] = "milliseconds";
    NumericResolutionUnit[NumericResolutionUnit["seconds"] = 1] = "seconds";
})(NumericResolutionUnit || (NumericResolutionUnit = {}));
/**namespace:Mapping.Norms */
var NormsLoading;
(function (NormsLoading) {
    NormsLoading[NormsLoading["lazy"] = 0] = "lazy";
    NormsLoading[NormsLoading["eager"] = 1] = "eager";
})(NormsLoading || (NormsLoading = {}));
/**namespace:Modules.Indices.Fielddata.String */
var StringFielddataFormat;
(function (StringFielddataFormat) {
    StringFielddataFormat[StringFielddataFormat["paged_bytes"] = 0] = "paged_bytes";
    StringFielddataFormat[StringFielddataFormat["doc_values"] = 1] = "doc_values";
    StringFielddataFormat[StringFielddataFormat["disabled"] = 2] = "disabled";
})(StringFielddataFormat || (StringFielddataFormat = {}));
/**namespace:Mapping */
var FieldIndexOption;
(function (FieldIndexOption) {
    FieldIndexOption[FieldIndexOption["analyzed"] = 0] = "analyzed";
    FieldIndexOption[FieldIndexOption["not_analyzed"] = 1] = "not_analyzed";
    FieldIndexOption[FieldIndexOption["no"] = 2] = "no";
})(FieldIndexOption || (FieldIndexOption = {}));
/**namespace:Mapping */
var TermVectorOption;
(function (TermVectorOption) {
    TermVectorOption[TermVectorOption["no"] = 0] = "no";
    TermVectorOption[TermVectorOption["yes"] = 1] = "yes";
    TermVectorOption[TermVectorOption["with_offsets"] = 2] = "with_offsets";
    TermVectorOption[TermVectorOption["with_positions"] = 3] = "with_positions";
    TermVectorOption[TermVectorOption["with_positions_offsets"] = 4] = "with_positions_offsets";
    TermVectorOption[TermVectorOption["with_positions_offsets_payloads"] = 5] = "with_positions_offsets_payloads";
})(TermVectorOption || (TermVectorOption = {}));
/**namespace:Mapping.Types.Core.String */
var IndexOptions;
(function (IndexOptions) {
    IndexOptions[IndexOptions["docs"] = 0] = "docs";
    IndexOptions[IndexOptions["freqs"] = 1] = "freqs";
    IndexOptions[IndexOptions["positions"] = 2] = "positions";
    IndexOptions[IndexOptions["offsets"] = 3] = "offsets";
})(IndexOptions || (IndexOptions = {}));
/**namespace:Modules.Indices.Fielddata.GeoPoint */
var GeoPointFielddataFormat;
(function (GeoPointFielddataFormat) {
    GeoPointFielddataFormat[GeoPointFielddataFormat["array"] = 0] = "array";
    GeoPointFielddataFormat[GeoPointFielddataFormat["doc_values"] = 1] = "doc_values";
    GeoPointFielddataFormat[GeoPointFielddataFormat["compressed"] = 2] = "compressed";
    GeoPointFielddataFormat[GeoPointFielddataFormat["disabled"] = 3] = "disabled";
})(GeoPointFielddataFormat || (GeoPointFielddataFormat = {}));
/**namespace:Mapping.Types.Geo.GeoShape */
var GeoTree;
(function (GeoTree) {
    GeoTree[GeoTree["geohash"] = 0] = "geohash";
    GeoTree[GeoTree["quadtree"] = 1] = "quadtree";
})(GeoTree || (GeoTree = {}));
/**namespace:Mapping.Types.Geo.GeoShape */
var GeoOrientation;
(function (GeoOrientation) {
    GeoOrientation[GeoOrientation["cw"] = 0] = "cw";
    GeoOrientation[GeoOrientation["ccw"] = 1] = "ccw";
})(GeoOrientation || (GeoOrientation = {}));
/**namespace:DefaultLanguageConstruct */
var HttpMethod;
(function (HttpMethod) {
    HttpMethod[HttpMethod["GET"] = 0] = "GET";
    HttpMethod[HttpMethod["POST"] = 1] = "POST";
    HttpMethod[HttpMethod["PUT"] = 2] = "PUT";
    HttpMethod[HttpMethod["DELETE"] = 3] = "DELETE";
    HttpMethod[HttpMethod["HEAD"] = 4] = "HEAD";
})(HttpMethod || (HttpMethod = {}));
/**namespace:DefaultLanguageConstruct */
var Bytes;
(function (Bytes) {
    Bytes[Bytes["b"] = 0] = "b";
    Bytes[Bytes["k"] = 1] = "k";
    Bytes[Bytes["m"] = 2] = "m";
    Bytes[Bytes["g"] = 3] = "g";
})(Bytes || (Bytes = {}));
/**namespace:DefaultLanguageConstruct */
var Level;
(function (Level) {
    Level[Level["cluster"] = 0] = "cluster";
    Level[Level["indices"] = 1] = "indices";
    Level[Level["shards"] = 2] = "shards";
})(Level || (Level = {}));
/**namespace:DefaultLanguageConstruct */
var WaitForStatus;
(function (WaitForStatus) {
    WaitForStatus[WaitForStatus["green"] = 0] = "green";
    WaitForStatus[WaitForStatus["yellow"] = 1] = "yellow";
    WaitForStatus[WaitForStatus["red"] = 2] = "red";
})(WaitForStatus || (WaitForStatus = {}));
/**namespace:DefaultLanguageConstruct */
/**namespace:DefaultLanguageConstruct */
var ExpandWildcards;
(function (ExpandWildcards) {
    ExpandWildcards[ExpandWildcards["open"] = 0] = "open";
    ExpandWildcards[ExpandWildcards["closed"] = 1] = "closed";
    ExpandWildcards[ExpandWildcards["none"] = 2] = "none";
    ExpandWildcards[ExpandWildcards["all"] = 3] = "all";
})(ExpandWildcards || (ExpandWildcards = {}));
/**namespace:DefaultLanguageConstruct */
var SuggestMode;
(function (SuggestMode) {
    SuggestMode[SuggestMode["missing"] = 0] = "missing";
    SuggestMode[SuggestMode["popular"] = 1] = "popular";
    SuggestMode[SuggestMode["always"] = 2] = "always";
})(SuggestMode || (SuggestMode = {}));
/**namespace:DefaultLanguageConstruct */
var SearchType;
(function (SearchType) {
    SearchType[SearchType["query_then_fetch"] = 0] = "query_then_fetch";
    SearchType[SearchType["query_and_fetch"] = 1] = "query_and_fetch";
    SearchType[SearchType["dfs_query_then_fetch"] = 2] = "dfs_query_then_fetch";
    SearchType[SearchType["dfs_query_and_fetch"] = 3] = "dfs_query_and_fetch";
    SearchType[SearchType["count"] = 4] = "count";
    SearchType[SearchType["scan"] = 5] = "scan";
})(SearchType || (SearchType = {}));
/**namespace:DefaultLanguageConstruct */
var ThreadType;
(function (ThreadType) {
    ThreadType[ThreadType["cpu"] = 0] = "cpu";
    ThreadType[ThreadType["wait"] = 1] = "wait";
    ThreadType[ThreadType["block"] = 2] = "block";
})(ThreadType || (ThreadType = {}));
/**namespace:DefaultLanguageConstruct */
var VersionType;
(function (VersionType) {
    VersionType[VersionType["internal"] = 0] = "internal";
    VersionType[VersionType["external"] = 1] = "external";
    VersionType[VersionType["external_gte"] = 2] = "external_gte";
    VersionType[VersionType["force"] = 3] = "force";
})(VersionType || (VersionType = {}));
/**namespace:DefaultLanguageConstruct */
var Consistency;
(function (Consistency) {
    Consistency[Consistency["one"] = 0] = "one";
    Consistency[Consistency["quorum"] = 1] = "quorum";
    Consistency[Consistency["all"] = 2] = "all";
})(Consistency || (Consistency = {}));
/**namespace:DefaultLanguageConstruct */
var DefaultOperator;
(function (DefaultOperator) {
    DefaultOperator[DefaultOperator["AND"] = 0] = "AND";
    DefaultOperator[DefaultOperator["OR"] = 1] = "OR";
})(DefaultOperator || (DefaultOperator = {}));
/**namespace:DefaultLanguageConstruct */
var OpType;
(function (OpType) {
    OpType[OpType["index"] = 0] = "index";
    OpType[OpType["create"] = 1] = "create";
})(OpType || (OpType = {}));
/**namespace:DefaultLanguageConstruct */
var Format;
(function (Format) {
    Format[Format["detailed"] = 0] = "detailed";
    Format[Format["text"] = 1] = "text";
})(Format || (Format = {}));
/**namespace:DefaultLanguageConstruct */
var PercolateFormat;
(function (PercolateFormat) {
    PercolateFormat[PercolateFormat["ids"] = 0] = "ids";
})(PercolateFormat || (PercolateFormat = {}));
