from approvaltests import verify

from texttest_fixture import main


def test_gilded_rose_approvals(monkeypatch, capsys):
    monkeypatch.setattr("sys.argv", ["texttest_fixture.py", "30"])
    main()
    verify(capsys.readouterr().out)
