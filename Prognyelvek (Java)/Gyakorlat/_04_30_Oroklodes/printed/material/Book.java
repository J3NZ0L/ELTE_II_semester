package _04_30_Oroklodes.printed.material;

public class Book{
    public static final String defaultAuthor="John SteinBack";

    public static final String defaultTitle="Of Mice and Men";

    public static final int defaultPageCount=107;

    private String author;

    private String title;

    protected int pageCount;

    public Book() {
        this.initBook(defaultAuthor, defaultTitle, defaultPageCount);
    }    

    public Book(String author, String title, int pageCount) {
        this.initBook(author,title, pageCount);
    }

    public String getAuthor() {
        return author;
    }

    public String getTitle() {
        return title;
    }

    public int getPageCount() {
        return pageCount;
    }

    private void checkInitData(String author, String title, int pageCount) { //TODO
        if (author.length<2) {
            throw new IllegalArgumentException("Author must be at least 2 characters long.");
        }
        if (title.length<4) {
            throw new IllegalArgumentException("Title must be at least 4 characters long.");
        }
        if (pageCount <= 0) {
            throw new IllegalArgumentException("Page count must be positive.");
        }
    }

    public String createReference(String author, int title, int pageCount) { //TODO
        return author + ": " + title + " (" + pageCount + " pages)";
    }

    public static Book decode(String reference) { //TODO
        String[] parts = reference.split("[;:]");
        String author = parts[0];
        String[] titleAndPageCount = parts[1].split(" \\(");
        String title = titleAndPageCount[0];
        int pageCount = Integer.parseInt(titleAndPageCount[1].substring(0, titleAndPageCount[1].length() - 7));
        return new Book(author, title, pageCount);
    }

    protected String getAuthorWithInitials() { //TODO
        String[] parts = author.split(" ");
        StringBuilder initials = new StringBuilder();
        for (String part : parts) {
            initials.append(part.charAt(0));
        }
        return initials.toString();
    }

    public int getPrice(){
        return pageCount;
    }

    public String getShortInfo(){
        return "0";
    }

    protected void initBook(String author, String title, int pagecount){
        checkInitData(author,title,pageCount);
        this.author = author;
        this.title = title;
        this.pageCount = pageCount;
    }

    @Override
    public String toString(){
        return this.author+": "+this.title+"; "+this.pageCount;
    } 
}