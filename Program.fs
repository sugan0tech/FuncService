open FSharp.Data
open System.IO


let getHtml (htmlFile: string) : HtmlDocument option =
    try
        let html = HtmlDocument.Load(htmlFile)
        Some(html)
    with
        ex ->
            printfn $"Error: {ex}"
            None
            
let htmlPath = Path.Join(__SOURCE_DIRECTORY__, "Test.html")

let getLinks (html: HtmlDocument option)  =
    match html with
    | Some x -> x.Descendants ["a"]
    | None -> Seq.empty

let getLinksFromHtml = getHtml >> getLinks
htmlPath |> getLinksFromHtml |> fun links -> printfn $"{links}"

let int32Func = fun input -> input / 3

let num: int = 89
let list: list<string> = [ "a"; "b"; "c" ]

let mutable cityName: string = "chennai"
cityName <- "test"
printfn $"{cityName}cityName"


let addOne x = x + 1
printfn $"{addOne(1)}"
let addTwo x: int = x + 2
printfn $"{addTwo(1)}"
