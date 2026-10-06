
import pytest
from approvaltests.reporters.report_quietly import ReportQuietly
from approvaltests import set_default_reporter


@pytest.fixture(autouse=True, scope="session")
def quiet_approval_reporter():
    set_default_reporter(ReportQuietly())
