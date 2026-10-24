namespace SyimykCV.Models;

public static class Translations
{
    public static readonly Dictionary<string, Dictionary<string, string>> Data = new()
    {
        ["en"] = new Dictionary<string, string>
        {
            ["nav.about"] = "About",
            ["nav.skills"] = "Skills",
            ["nav.projects"] = "Projects",
            ["nav.education"] = "Education",
            ["nav.contact"] = "Contact",

            ["hero.badge"] = "Available for Junior & Internship roles · Poland / Remote",
            ["hero.role"] = "Junior .NET Developer",
            ["hero.tagline"] = "C# · ASP.NET Core · Clean Architecture · Networking & Systems",
            ["hero.cta.contact"] = "Get in touch",
            ["hero.cta.cv"] = "Download CV",

            ["about.title"] = "About me",
            ["about.text"] = "Software Engineering student focused on building clean, reliable backend systems with C# and .NET. Backed by solid hands-on knowledge of networking protocols, Linux administration, and relational databases. Currently expanding practical skills through a .NET internship at XSoft, and actively seeking an internship or Junior Developer role.",
            ["about.location"] = "Based in Rzeszów, Poland (Open to Relocation / Remote)",

            ["skills.title"] = "Technical Skills",
            ["skills.backend"] = "Backend & Software Engineering",
            ["skills.networking"] = "Networking & Security",
            ["skills.tools"] = "Systems, DevOps & Tools",

            ["projects.title"] = "Featured Projects",
            
            ["proj0.title"] = ".NET Web API & Client Architecture",
            ["proj0.tool"] = "XSoft Internship · C# / ASP.NET Core",
            ["proj0.p1"] = "Engineered a modular Web API using DTOs and repository patterns to isolate domain models from client-facing contracts.",
            ["proj0.p2"] = "Implemented stateless JWT Bearer authentication to secure endpoints with claim-based authorization.",
            ["proj0.p3"] = "Integrated external REST APIs and developed a dedicated console client application for end-to-end testing and data ingestion.",

            ["proj4.title"] = "Tic-Tac-Toe Extended (Desktop & Web)",
            ["proj4.tool"] = "C# / .NET 8 / WPF / SQLite / xUnit",
            ["proj4.p1"] = "Co-developed an extended Tic-Tac-Toe desktop application with WPF and persistent game state in SQLite as part of a 3-person agile team.",
            ["proj4.p2"] = "Authored extensive unit tests with xUnit covering core game algorithms, winning state checks, and data access integrity.",
            ["proj4.p3"] = "Delivered an additional playable web client and presented software architecture in an academic defense for the Programming Languages course.",

            ["proj1.title"] = "Enterprise Network Security Topology",
            ["proj1.tool"] = "Cisco Packet Tracer · Network Engineering",
            ["proj1.p1"] = "Architected a multi-tier enterprise network topology with Cisco routers, multi-layer switches, and servers, validating full L2/L3 connectivity.",
            ["proj1.p2"] = "Configured core infrastructure services: DHCP pools, DNS, inter-VLAN routing, and ACL packet filters to limit exposure.",
            ["proj1.p3"] = "Documented IP subnetting schemes, addressing tables, and step-by-step ICMP/TCP troubleshooting test matrices.",

            ["proj2.title"] = "Phishing & Social Engineering Defense Module",
            ["proj2.tool"] = "Cybersecurity Training Module",
            ["proj2.p1"] = "Authored an interactive awareness module breaking down phishing vectors, safe credential handling, and automated reporting triage.",
            ["proj2.p2"] = "Created inspection checklists for technical email headers, domain typosquatting, and deceptive URL payloads.",
            ["proj2.p3"] = "Drafted an executive defense guideline recommended for employee security onboarding procedures.",

            ["proj3.title"] = "Linux Administration & Server Hardening Lab",
            ["proj3.tool"] = "Linux (Ubuntu/Debian) · Bash Lab",
            ["proj3.p1"] = "Managed POSIX permissions, user/group privileges, SSH key-only access, and systemd service daemons in a dedicated lab environment.",
            ["proj3.p2"] = "Applied baseline OS hardening (UFW firewall rules, automated updates, least-privilege principles, port audits).",
            ["proj3.p3"] = "Conducted auth and system log audits (journalctl) and wrote Bash scripts to automate routine health diagnostics.",

            ["proj.btn.code"] = "Source Code",
            ["proj.btn.demo"] = "Live Demo",

            ["education.title"] = "Education",
            ["education.degree"] = "BSc in IT Programming / Computer Science",
            ["education.school"] = "University of Information Technology and Management (WSIiZ), Rzeszów",
            ["education.years"] = "2024 — 2027",
            ["education.coursework"] = "Relevant coursework: Programming Languages (C#, Python), Computer Networks (TCP/IP, DNS/DHCP), Linux Administration, Cybersecurity Fundamentals, Relational Databases (SQL).",

            ["certs.title"] = "Certifications",
            ["cert1"] = "Cybersecurity Essentials",
            ["cert2"] = "Python Essentials",
            ["cert3"] = "Network Support and Security",
            ["cert4"] = "Ethical Hacker",
            ["cert5"] = "SpaceShield Hackathon",
            ["certs.issuer.hackathon"] = "Hackathon Participation",
            ["certs.view"] = "View Certificate",
            ["certs.issuer"] = "Cisco Networking Academy",

            ["languages.title"] = "Languages",
            ["lang.ru"] = "Russian",
            ["lang.ru.level"] = "Native",
            ["lang.en"] = "English",
            ["lang.en.level"] = "B1/B2 (Working Proficiency)",
            ["lang.pl"] = "Polish",
            ["lang.pl.level"] = "A1/A2 (Elementary)",

            ["contact.title"] = "Let's Connect",
            ["contact.text"] = "I am actively looking for internship or junior opportunities in Software Development (C# / .NET) and IT Engineering. Feel free to reach out via email, phone, or LinkedIn!",
            ["contact.email"] = "Email",
            ["contact.phone"] = "Phone",
            ["contact.github"] = "GitHub",
            ["contact.linkedin"] = "LinkedIn",
            ["contact.copy"] = "Click to copy email",
            ["contact.copied"] = "Email copied to clipboard! ✓",

            ["footer.rights"] = "All rights reserved.",
        },
        ["pl"] = new Dictionary<string, string>
        {
            ["nav.about"] = "O mnie",
            ["nav.skills"] = "Umiejętności",
            ["nav.projects"] = "Projekty",
            ["nav.education"] = "Edukacja",
            ["nav.contact"] = "Kontakt",

            ["hero.badge"] = "Otwarty na staże i stanowiska juniorskie · Polska / Zdalnie",
            ["hero.role"] = "Młodszy Programista .NET",
            ["hero.tagline"] = "C# · ASP.NET Core · Clean Architecture · Sieci i Systemy",
            ["hero.cta.contact"] = "Napisz do mnie",
            ["hero.cta.cv"] = "Pobierz CV",

            ["about.title"] = "O mnie",
            ["about.text"] = "Student programowania IT zorientowany na tworzenie czystego, niezawodnego oprogramowania backendowego w C# i .NET. Posiadam solidne podstawy w zakresie sieci komputerowych, administracji systemami Linux oraz relacyjnych baz danych. Obecnie rozwijam umiejętności praktyczne podczas stażu .NET w XSoft i aktywnie poszukuję stażu lub roli Junior Developera.",
            ["about.location"] = "Rzeszów, Polska (Możliwość relokacji / Praca zdalna)",

            ["skills.title"] = "Umiejętności techniczne",
            ["skills.backend"] = "Backend & Inżynieria Oprogramowania",
            ["skills.networking"] = "Sieci & Bezpieczeństwo",
            ["skills.tools"] = "Systemy, DevOps & Narzędzia",

            ["projects.title"] = "Wybrane Projekty",
            
            ["proj0.title"] = ".NET Web API i architektura klienta",
            ["proj0.tool"] = "Staż w XSoft · C# / ASP.NET Core",
            ["proj0.p1"] = "Zaprojektowałem modułowe Web API z wykorzystaniem wzorca DTO i repozytorium, aby odizolować modele domenowe od kontraktów klienckich.",
            ["proj0.p2"] = "Wdrożyłem bezstanowe uwierzytelnianie JWT Bearer w celu zabezpieczenia endpointów z autoryzacją opartą na rolach i roszczeniach.",
            ["proj0.p3"] = "Zintegrowałem zewnętrzne API REST oraz stworzyłem dedykowaną aplikację konsolową do kompleksowych testów przepływu danych.",

            ["proj4.title"] = "Tic-Tac-Toe Extended (Desktop & Web)",
            ["proj4.tool"] = "C# / .NET 8 / WPF / SQLite / xUnit",
            ["proj4.p1"] = "Współtworzyłem rozbudowaną aplikację gry w kółko i krzyżyk w technologii WPF z trwałością danych w SQLite w 3-osobowym zespole.",
            ["proj4.p2"] = "Napisałem testy jednostkowe w xUnit weryfikujące algorytmy gry, wykrywanie wygranej oraz integralność warstwy danych.",
            ["proj4.p3"] = "Stworzyłem dodatkową grywalną wersję przeglądarkową i obroniłem architekturę projektu w prezentacji akademickiej.",

            ["proj1.title"] = "Topologia bezpieczeństwa sieci korporacyjnej",
            ["proj1.tool"] = "Cisco Packet Tracer · Inżynieria sieciowa",
            ["proj1.p1"] = "Zaprojektowałem wielowarstwową topologię sieci przedsiębiorstwa (routery, przełączniki L2/L3, serwery), weryfikując łączność L2/L3.",
            ["proj1.p2"] = "Skonfigurowałem kluczowe usługi: pule DHCP, DNS, routing między VLAN-ami oraz filtry ACL minimalizujące powierzchnię ataku.",
            ["proj1.p3"] = "Opracowałem pełną dokumentację adresacji IP, schematy podsieci oraz macierze testów diagnostycznych ICMP/TCP.",

            ["proj2.title"] = "Moduł obrony przed phishingiem i socjotechniką",
            ["proj2.tool"] = "Moduł szkoleniowy z cyberbezpieczeństwa",
            ["proj2.p1"] = "Stworzyłem moduł uświadamiający omawiający wektory ataków phishingowych, bezpieczne procedury poświadczeń i schemat raportowania.",
            ["proj2.p2"] = "Zaprojektowałem listy kontrolne do weryfikacji nagłówków technicznych wiadomości e-mail, literówek w domenach i podejrzanych linków.",
            ["proj2.p3"] = "Przygotowałem jednostronicowy przewodnik bezpieczeństwa rekomendowany do wdrożeń pracowniczych.",

            ["proj3.title"] = "Laboratorium administracji i hartowania systemu Linux",
            ["proj3.tool"] = "Linux (Ubuntu/Debian) · Warsztat Bash",
            ["proj3.p1"] = "Zarządzałem uprawnieniami POSIX, grupami, dostępem SSH opartym wyłącznie na kluczach oraz demonami systemd.",
            ["proj3.p2"] = "Zastosowałem zasady hartowania systemu (reguły zapory UFW, automatyczne aktualizacje, zasada minimalnych uprawnień).",
            ["proj3.p3"] = "Prowadziłem audyt logów systemowych (journalctl) i napisałem skrypty Bash do automatyzacji powtarzalnych testów sprawności.",

            ["proj.btn.code"] = "Kod źródłowy",
            ["proj.btn.demo"] = "Wersja live",

            ["education.title"] = "Edukacja",
            ["education.degree"] = "Inżynier / Licencjat z Programowania IT",
            ["education.school"] = "Wyższa Szkoła Informatyki i Zarządzania (WSIiZ), Rzeszów",
            ["education.years"] = "2024 — 2027",
            ["education.coursework"] = "Wybrane przedmioty: Języki programowania (C#, Python), sieci komputerowe (TCP/IP, DNS/DHCP), administracja Linux, cyberbezpieczeństwo, relacyjne bazy danych (SQL).",

            ["certs.title"] = "Certyfikaty",
            ["cert1"] = "Cybersecurity Essentials",
            ["cert2"] = "Python Essentials",
            ["cert3"] = "Network Support and Security",
            ["cert4"] = "Ethical Hacker",
            ["cert5"] = "SpaceShield Hackathon",
            ["certs.issuer.hackathon"] = "Udział w hackathonie",
            ["certs.view"] = "Zobacz certyfikat",
            ["certs.issuer"] = "Cisco Networking Academy",

            ["languages.title"] = "Języki",
            ["lang.ru"] = "Rosyjski",
            ["lang.ru.level"] = "Ojczysty (Native)",
            ["lang.en"] = "Angielski",
            ["lang.en.level"] = "B1/B2 (Średnio zaawansowany)",
            ["lang.pl"] = "Polski",
            ["lang.pl.level"] = "A1/A2 (Podstawowy)",

            ["contact.title"] = "Skontaktujmy się",
            ["contact.text"] = "Jestem otwarty na oferty staży i stanowisk juniorskich w programowaniu (C# / .NET) oraz inżynierii IT. Zapraszam do kontaktu mailowego, telefonicznego lub na LinkedIn!",
            ["contact.email"] = "Email",
            ["contact.phone"] = "Telefon",
            ["contact.github"] = "GitHub",
            ["contact.linkedin"] = "LinkedIn",
            ["contact.copy"] = "Kliknij, aby skopiować email",
            ["contact.copied"] = "Email skopiowany do schowka! ✓",

            ["footer.rights"] = "Wszelkie prawa zastrzeżone.",
        },
    };
}
